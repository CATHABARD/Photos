using Photos.Modeles;
using Photos.Services;

namespace Photos
{
    public partial class nouvellePhoto : Form
    {
        private Jour? jour;
        private Evenement? evenement;
        private Param? param;
        private string destination;
        private readonly ParamsService paramsService;
        private PhotosService photosService;
        private List<Photo>? listePhotos;
        readonly PhotosDbContext _context;

        public nouvellePhoto(PhotosDbContext context)
        {
            _context = context;
            InitializeComponent();
            paramsService = new (_context);
            photosService = new(_context);
        }

        /// <summary>
        /// Ouverture de nouvellePhoto dialog en passant les références de l'évènement et du jour
        /// </summary>
        /// <param name="e"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public DialogResult ShowDialog(Jour j, Evenement e)
        {
            jour = j;
            evenement = e;
            param = paramsService.GetParam("PathImages");

            string jourPath = j.Date.ToShortDateString().Replace('/', '-');
            destination = param.Valeur.Trim() +
                @"\" +
                evenement.Titre.Trim() +
                @"\" +
                jourPath.Substring(6, 4) +
                jourPath.Substring(2, 4) +
                jourPath.Substring(0, 2) +
                @"\";

            listePhotos = new ();
            photosService = new (_context, j);

            return ShowDialog();
        }

        private void OpenFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Images(*.JPG; *.GIF; PNG)| *.JPG; *.GIF; *.PNG",
                Multiselect = true
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < ofd.FileNames.Length; i++)
                {
                    int imageIndex = listView1.SmallImageList.Images.Count;
                    string path = ofd.FileNames[i];

                    ListViewItem li = listView1.Items.Add(path, imageIndex);
                    li.Checked = true;
                    li.Name = jour.Commentaire;
                    DateTime d = File.GetLastWriteTime(path);
                    if (d.Day != jour.Date.Day || d.Month != jour.Date.Month || d.Year != jour.Date.Year)
                    {
                        li.ForeColor = Color.Red;
                        li.Checked = false;
                        label1.Visible = true;
                        supprimer.Visible = true;
                    }
                }
            }
        }

        /// <summary>
        /// Enregistre les photos dans la base
        /// </summary>
        /// <param name="uncheckedItems"></param>
        private void Save()
        {
            foreach (ListViewItem i in listView1.Items)
            {
                i.Checked = true;
                string fileName = i.Text.Substring(i.Text.LastIndexOf('\\') + 1);
                Photo p = new Photo
                {
                    Commentaire = i.Name,
                    Adresse = Path.Combine(destination, fileName)
                };
                DateTime d = File.GetLastWriteTime(i.Text);
                p.Heure = d;
                p.IdJour = jour.Id;
                listePhotos.Add(p);
                try
                {
                    File.Copy(i.Text, p.Adresse, true);
                }
                catch (DirectoryNotFoundException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch { }
            }
            photosService.AddPhotos(listePhotos);
        }

        /// <summary>
        /// Appelle la fonction Save et ferme la fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonValider_Click(object sender, EventArgs e)
        {
            Save();
            listView1.SmallImageList.Dispose();
            listView1.Items.Clear();
            Close();
        }

        /// <summary>
        /// Ferme la fenêtre sans sauvegarder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Supprime les items non cochés
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Supprimer_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem i in listView1.Items)
            {
                if(!i.Checked)
                {
                    listView1.Items.Remove(i);
                }
            }
            label1.Visible = false;
            supprimer.Visible = false;
        }
    }
}
