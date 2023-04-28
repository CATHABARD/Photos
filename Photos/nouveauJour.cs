using Photos.Modeles;
using Photos.Services;

namespace Photos
{
    public partial class NouveauJour : Form
    {
        readonly Evenement _evenement;
        private Jour? jour;
        public Jour? Jour { get { return jour; } }
        readonly EvenementsService evenementsService;
        readonly PhotosDbContext _context;
        private List<Evenement> evenements;
        readonly JoursService joursService;

        public NouveauJour(PhotosDbContext context, Evenement e)
        {
            _context = context;
            InitializeComponent();
            _evenement = e;
            evenementsService = new (_context);
            joursService = new (_context);
            // remplassage du ComboBox evenement
            evenements = evenementsService.GetEvenements();
        }

        private void NouveauJour_Load(object sender, EventArgs e)
        {
            Guid resultat = Guid.NewGuid();
            id.Text = resultat.ToString("D");

            foreach (Evenement _e in evenements)
            {
                evenement.Items.Add(_e);
            }
            evenement.SelectedValue = _evenement.Id;
        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Valider_Click(object sender, EventArgs e)
        {
            if (evenement.SelectedValue == null)
                return;

            string? idEvenement = evenement.SelectedValue.ToString();
            foreach (Evenement rowEvenement in evenements)
            {
                if (rowEvenement.Id == idEvenement)
                {
                    DateTime dte = rowEvenement.Date.Date;
                    int duree = rowEvenement.Duree;
                    DateTime dteFin = dte.AddDays(duree).Date;
                    // Si la date 
                    if(date.Value >= dte && date.Value <= dte.AddDays(duree))
                    {
                        // Si un texte a été saisi dans le champs remarques
                        if(remarques.Text.Length > 0)
                        {
                            Jour jour = new ();
                            jour.Id = id.Text;
                            jour.EvenementId = evenement.SelectedValue.ToString()!;
                            jour.Date = date.Value;
                            jour.Commentaire = remarques.Text;
                            jour.Id = joursService.AddJour(jour);

                            DialogResult = DialogResult.OK;
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Veuillez saisir un petit texte qui sera joint aux photos du jour, il sera destiné à situer la vue.");
                            remarques.Focus();

                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("La date saisie sort de la période de l'évènement.");
                        date.Focus();

                        return;
                    }
                }
            }


        }
    }
}
