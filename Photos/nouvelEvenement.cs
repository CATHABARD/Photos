using Photos.Modeles;
using Photos.Services;

namespace Photos
{
    public partial class NouvelEvenement : Form
    {
        readonly EvenementsService EvenementsService;
        readonly Evenement evenement;
        public Evenement Evenement { get => evenement; }
        readonly PhotosDbContext _context;

        public NouvelEvenement(PhotosDbContext context)
        {
            _context = context;
            InitializeComponent();
            EvenementsService = new (_context);
            evenement = new Evenement();
        }

        private void ValiderBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            evenement.Id = id.Text;
            evenement.Titre = titre.Text;
            evenement.Date = dateTimePicker1.Value;
            evenement.Duree = (int)numericUpDown1.Value;
            evenement.Commentaire = remarques.Text;
            EvenementsService.AddEvenement(evenement);

            Close();
        }

        private void AnnulerBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
