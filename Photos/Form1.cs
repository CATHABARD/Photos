using Photos.Modeles;
using Photos.Services;
using System.Collections;

namespace Photos
{
    public partial class Form1 : Form
    {
        private List<Evenement> evenements;
        private readonly EvenementsService evenementsService;
        private Evenement? evenementCourant;
        private readonly JoursService joursService;
        private Jour? jourCourant;
        private PhotosService photosService;
        private List<Photo> photos = new ();
        private TreeNode? nodeCourant = null;
        private bool isSelectedNode = false;
        private List<Param> parametres;
        internal List<Param> Parametres { get => parametres; set => parametres = value; }
        readonly ParamsService paramsService;
        private readonly Param? paramPathImages;
        private DirectoryInfo? diEvenement;
        private readonly DirectoryInfo diRacine;
        readonly PhotosDbContext _context;


        private int first = 0;
        private const int itemsByPage = 18;


        public Form1(PhotosDbContext photosDbContext)
        {
            _context = photosDbContext;
            paramsService = new ParamsService(_context);
            parametres = paramsService.GetParams();

            // Récupérer le répertoire par défaut
            paramPathImages = paramsService.GetParam("PathImages");

            if(paramPathImages != null)
                diRacine = new DirectoryInfo(paramPathImages.Valeur);
            else
                diRacine = new DirectoryInfo("MyDocuments");

            InitializeComponent();
            evenementsService = new (_context);
            joursService = new (_context);
            evenements = evenementsService.GetEvenementsDetailles();
            photosService = new (_context);
            evenementCourant = null;
            progressBar1.Style = ProgressBarStyle.Continuous;

            if (evenements.Count > 0)
            {
                InitTreeView();
            }
        }

        private void InitTreeView()
        {
            TreeNode N;

            treeView1.Nodes.Clear();
            // Remplissage du TreeView
            treeView1.BeginUpdate();
            foreach (Evenement e in evenements)
            {
                TreeNode n = treeView1.Nodes.Add(e.Id, (e.Titre.Trim() + " (" + e.Date.ToShortDateString() + ")"));
                // rechercher les jours de l'évènement
                foreach (Jour j in e.Jours)
                {
                    N = n.Nodes.Add(j.Id, j.Date.ToShortDateString());
                }

                treeView1.SelectedNode = null;
            }
            treeView1.EndUpdate();
        }

        /// <summary>
        /// Création d'un nouvel évènement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CréerUnÉvénementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (NouvelEvenement nouvelEvenement = new (_context))
            {
                isSelectedNode = false;
                if (nouvelEvenement.ShowDialog() == DialogResult.OK)
                {
                    evenements = evenementsService.GetEvenementsDetailles();
                    evenementCourant = nouvelEvenement.Evenement;
                    InitTreeView();
                    // Créer un dossier pour l'évènement
                    diEvenement = diRacine.CreateSubdirectory(evenementCourant.Titre);
                    Form1_Shown(this, null);
                }
            }
        }

        /// <summary>
        /// Ajouter un jour à l'évènement courant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CréerUnJourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("En créant un nouveau jour, un dossier sera ajouté dans le dossier " + evenementCourant.Titre,
                "Ajout d'un jour",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (NouveauJour nouveauJour = new (_context, evenementCourant))
                {
                    isSelectedNode = false;
                    if (nouveauJour.ShowDialog() == DialogResult.OK)
                    {
                        evenements = evenementsService.GetEvenementsDetailles();
                        InitTreeView();
                        Form1_Shown(this, null);
                        jourCourant = nouveauJour.Jour;

                        // Crée un dossier au format AAAA-MM-JJ
                        string jourPath = jourCourant.Date.ToShortDateString().Replace('/', '-');
                        string destination =
                            jourPath.Substring(6, 4) +
                            jourPath.Substring(2, 4) +
                            jourPath.Substring(0, 2);
                        // Créer un dossier pour le jour
                        diEvenement.CreateSubdirectory(destination);
                    }
                }
            }
        }

        /// <summary>
        /// Ajout de photos au jour sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AjouterUnePhotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (jourCourant != null && evenementCourant != null)
            {
                using (nouvellePhoto nouvellePhoto = new(_context))
                {
                    nouvellePhoto.ShowDialog(jourCourant, evenementCourant);
                }
                GetListePhotos();
                InitListePhotos();
                ButtonFirst_Click(this, null);
            }
        }

        /// <summary>
        /// Mise à jour de l'interface en fonction de l'évènement ou du jour sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (!isSelectedNode || e == null || e.Node == null)
                return;

            this.splitContainer2.Panel1.Controls.Clear();
            nodeCourant = e.Node;

            // Si on est au niveau des jours
            if (e.Node.Level == 1)
            {
                jourCourant = joursService.GetJour(e.Node.Name);
                evenementCourant = evenementsService.GetEvenement(jourCourant.EvenementId);
                ajouterUnePhotoToolStripMenuItem.Enabled = true;
                GetListePhotos();
                first = 0;

                buttonFirst.Enabled = false;
                buttonPrevious.Enabled = false;
                if (photos.Count > itemsByPage)
                {
                    buttonFollowing.Enabled = true;
                    buttonLast.Enabled = true;
                    labelPosition.Text = "Photos " + (first + 1).ToString() + " à " + (first + itemsByPage).ToString() + " sur " + photos.Count.ToString();
                }
                else
                {
                    buttonFollowing.Enabled = false;
                    buttonLast.Enabled = false;
                    labelPosition.Text = "Photos " + (first + 1).ToString() + " à " + photos.Count.ToString() + " sur " + photos.Count.ToString();
                }
                InitListePhotos();
                // Trouver le dossier du jour
                string jourPath = jourCourant.Date.ToShortDateString().Replace('/', '-');
                jourPath = paramPathImages.Valeur.Trim() + @"\" + evenementCourant.Titre.Trim() + @"\" + jourPath.Substring(6, 4) + jourPath.Substring(2, 4) + jourPath.Substring(0, 2);
                new DirectoryInfo(jourPath);
                string evenementPath = paramPathImages.Valeur.Trim() + @"\" + evenementCourant.Titre.Trim();
                diEvenement = new DirectoryInfo(evenementPath);
                EvenementTextBox.Text = evenementCourant.Titre + "\r\nDate " + evenementCourant.Date.ToShortDateString() + "\r\nd'une durée de  " + evenementCourant.Duree.ToString() + " jours";
                JourTextBox.Text = jourCourant.Date.ToShortDateString() + "\r\n" + jourCourant.Commentaire.Trim();
            }
            else // on est au niveau évènement
            {
                string idEvenement = e.Node.Name;
                evenementCourant = evenementsService.GetEvenement(idEvenement);
                jourCourant = null;
                ajouterUnePhotoToolStripMenuItem.Enabled = false;
                // Trouver le dossier de l'évènement
                string evenementPath = paramPathImages.Valeur.Trim() + @"\" + evenementCourant.Titre.Trim();
                diEvenement = new DirectoryInfo(evenementPath);
                EvenementTextBox.Text = evenementCourant.Titre + "\r\nDate " + evenementCourant.Date.ToShortDateString() + "\r\nd'une durée de  " + evenementCourant.Duree.ToString() + " jours";
                JourTextBox.Text = "";
            }
        }

        private void GetListePhotos()
        {
            if (photos != null)
                photos.Clear();
            string idJour = nodeCourant.Name;
            jourCourant = joursService.GetJour(idJour);
            photosService = new (_context, jourCourant);
            photos = photosService.GetPhotosJour(jourCourant);
        }

        private void InitListePhotos()
        {
            const int marge = 25;
            int ligne;
            int colonne;
            int hPas = 260;
            int vPas = 305;
            int i = 0;
            int indexPhoto = 0;

            if (nodeCourant == null || nodeCourant.Name == "")
                return;

            this.splitContainer2.Panel1.Visible = false;
            progressBar1.Visible = true;
            progressBar1.Maximum = itemsByPage;
            progressBar1.Step = 1;
            progressBar1.Value = 0;

            foreach (Photo p in photos)
            {
                if (i < first)
                {
                    i++;
                    continue;
                }
                progressBar1.PerformStep();
                ligne = indexPhoto / 6;
                colonne = indexPhoto % 6;
                try
                {
                    PhotoControl pc = new (_context, p)
                    {
                        Location = new System.Drawing.Point(marge + colonne * hPas, 15 + ligne * vPas),
                    };
                    pc.zoom += Pc_zoom;
                    pc.modifie += Pc_modifie;
                    splitContainer2.Panel1.Controls.Add(pc);
                    i++;
                    indexPhoto++;
                    if (indexPhoto >= itemsByPage)
                        break;
                }
                catch (OutOfMemoryException ex)
                {
                    MessageBox.Show(ex.Message);
                    break;
                }
                catch (DirectoryNotFoundException ex)
                {
                    if (MessageBox.Show(ex.Message + "\n\rVoulez-vous redéfinir l'adresse du fichier ?", "Erreur", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                        {
                            ChangePathPhotosJour(photos, folderBrowserDialog1.SelectedPath);
                            return;
                        }
                    }
                    else
                        return;
                }
            }
            splitContainer2.Panel1.Visible = true;
            progressBar1.Visible = false;
        }

        private void ChangePathPhotosJour(List<Photo> Photos, string path)
        {
            foreach (Photo p in Photos)
            {
                string fileName = Path.GetFileName(p.Adresse);
                p.Adresse = path + "\\" + fileName;
                PhotosService ps = new (_context);
                ps.UpdatePhoto(p);
            }
        }

        private void Pc_modifie(object sender, ModifiePhotoEventArgs e)
        {
            GetListePhotos();
            InitListePhotos();
        }

        private void Pc_zoom(object sender, ZoomPhotoEventArgs e)
        {
            using (ZoomPhoto zp = new ZoomPhoto(e.photo.Adresse))
            {
                zp.ShowDialog();
            }
        }

        private void QuitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int nbErreurs = 0;
            // Contrôle la validité des adresses des photos dans la base
            List<Evenement> evenements = evenementsService.GetEvenements();
            foreach (Evenement evenement in evenements)
            {
                Console.WriteLine(evenement);
                joursService.GetJoursEvenement(evenement);
                foreach (Jour jour in evenement.Jours)
                {
                    Console.WriteLine(jour);
                    List<Photo> photos = photosService.GetPhotosJour(jour);
                    foreach (Photo photo in photos)
                    {
                        Console.WriteLine(photo);
                        if (!File.Exists(photo.Adresse)) // le chemin spécifié n'existe pas
                        {
                            nbErreurs++;
                        }
                    }
                }
            }
            if (nbErreurs > 0) // s'il y a des erreurs
                MessageBox.Show(nbErreurs.ToString() + " erreurs dans la base de données");

            this.Close();
        }

        private void AProposMenuItem_Click(object sender, EventArgs e)
        {
            using (About about = new About())
            {
                about.ShowDialog();
            }
        }

        private void CarouselMenuItem_Click(object sender, EventArgs e)
        {
            using (Carousel carousel = new (_context))
            {
                carousel.ShowDialog(jourCourant);
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            isSelectedNode = true;

            TreeView1_AfterSelect(treeView1, new TreeViewEventArgs(treeView1.SelectedNode));
        }

        private void ButtonLast_Click(object sender, EventArgs e)
        {
            first = photos.Count - itemsByPage;
            buttonFirst.Enabled = true;
            buttonPrevious.Enabled = true;
            buttonFollowing.Enabled = false;
            buttonLast.Enabled = false;
            this.splitContainer2.Panel1.Controls.Clear();
            labelPosition.Text = "Photos " + (first + 1).ToString() + " à " + (first + itemsByPage).ToString() + " sur " + photos.Count.ToString();
            this.InitListePhotos();
        }

        private void ButtonFollowing_Click(object sender, EventArgs e)
        {
            first += itemsByPage;
            buttonFirst.Enabled = true;
            buttonPrevious.Enabled = true;
            labelPosition.Text = "Photos " + (first + 1).ToString() + " à " + (first + itemsByPage).ToString() + " sur " + photos.Count.ToString();
            if (first >= photos.Count - itemsByPage)
            {
                buttonFollowing.Enabled = false;
                buttonLast.Enabled = false;
                labelPosition.Text = "Photos " + (first + 1).ToString() + " à " + photos.Count.ToString() + " sur " + photos.Count.ToString();
            }
            this.splitContainer2.Panel1.Controls.Clear();
            this.InitListePhotos();
        }

        private void ButtonPrevious_Click(object sender, EventArgs e)
        {
            first -= itemsByPage;
            if (first <= 0)
            {
                first = 0;
                buttonFirst.Enabled = false;
                buttonPrevious.Enabled = false;
            }
            buttonFollowing.Enabled = true;
            buttonLast.Enabled = true;

            this.splitContainer2.Panel1.Controls.Clear();
            labelPosition.Text = "Photos " + (first + 1).ToString() + " à " + (first + itemsByPage).ToString() + " sur " + photos.Count.ToString();
            this.InitListePhotos();
        }

        private void ButtonFirst_Click(object sender, EventArgs? e)
        {
            first = 0;
            buttonFirst.Enabled = false;
            buttonPrevious.Enabled = false;
            buttonFollowing.Enabled = true;
            buttonLast.Enabled = true;
            this.splitContainer2.Panel1.Controls.Clear();
            if (photos.Count < itemsByPage)
                labelPosition.Text = "Photos " + (first + 1).ToString() + " à " + photos.Count.ToString() + " sur " + photos.Count.ToString();
            else
                labelPosition.Text = "Photos " + (first + 1).ToString() + " à " + (first + itemsByPage).ToString() + " sur " + photos.Count.ToString();
            this.InitListePhotos();
        }

        private void DéfinirUnDossierDeStockageMenuItem_Click(object sender, EventArgs? e)
        {
            MessageBox.Show("Le dossier que vous allez créer sera le dossier qui contiendra les photos que vous enregistrerez à l'avenir.");
            using (EditPathImages epi = new EditPathImages(paramPathImages.Valeur, _context))
            {
                epi.ShowDialog();
            }
        }

        private void TrasférerToutesLesPhotosMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Le transfer de l'ensemble des photos est une opération qui peut durer longtemps", "Transfer des photos", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                photos.Clear();
                splitContainer2.Panel1.Controls.Clear();
                Thread thread = new Thread(CpyFiles);
                thread.Start();
            }
        }

        private void CpyFiles()
        {
            DirectoryInfo di, di1, di2;

            using (MoveTo mt = new MoveTo(paramPathImages.Valeur.Trim()))
            {
                if (mt.ShowDialog() == DialogResult.OK)
                {
                    di = new DirectoryInfo(paramPathImages.Valeur);

                    // Parcourrir les evenements
                    List<Evenement> evenements = evenementsService.GetEvenements();
                    foreach (Evenement evenement in evenements)
                    {
                        string evenementPath = evenement.Titre.Trim().Replace(' ', '_');

                        if (!Directory.Exists(evenementPath))
                            di1 = di.CreateSubdirectory(evenementPath);
                        else
                            di1 = new DirectoryInfo(evenementPath);

                        // Parcourrir les jours de l'évènement
                        List<Jour> jours = joursService.GetJoursEvenement(evenement.Id);
                        foreach (Jour j in jours)
                        {
                            string jourPath = j.Date.ToShortDateString().Replace('/', '-');
                            jourPath = jourPath.Substring(6, 4) + jourPath.Substring(2, 4) + jourPath.Substring(0, 2);
                            di2 = di1.CreateSubdirectory(jourPath);
                            // Parcourrir les photos du jour pour les copier
                            List<Photo> photos = photosService.GetPhotosJour(j);
                            foreach (Photo p in photos)
                            {
                                string photoFileName = p.Adresse;
                                photoFileName = photoFileName.Substring(photoFileName.LastIndexOf('\\') + 1);
                                string path = paramPathImages.Valeur.Trim() + @"\" + evenementPath + @"\" + jourPath + @"\" + photoFileName;
                                try
                                {
                                    File.Copy(p.Adresse, path, true);
                                }
                                catch (DirectoryNotFoundException ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                                catch
                                {
                                    break;
                                }
                                // Modifier l'adresse dans la table Photos
                                p.Adresse = path;
                                photosService.UpdatePhoto(p);
                            }
                        }
                    }
                }
            }
            Thread.CurrentThread.Abort();
        }
    }
}
