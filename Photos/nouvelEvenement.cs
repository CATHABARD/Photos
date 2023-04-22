using Photos.Modeles;
using Photos.Services;
using System;
using System.Windows.Forms;

namespace Photos
{
    public partial class NouvelEvenement : Form
    {
        readonly EvenementsService EvenementsService;
        readonly Evenement evenement;
        public Evenement Evenement { get => evenement; }

        public NouvelEvenement()
        {
            InitializeComponent();
            EvenementsService = new EvenementsService();
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
