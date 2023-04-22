using Photos.Modeles;
using System;
using System.Windows.Forms;
using static Photos.PhotosDBDataSet;

namespace Photos
{
    public partial class NouveauJour : Form
    {
        EvenementsDataTable evenementsDataTable;
        readonly Evenement _evenement;
        private Jour jour;
        public Jour Jour { get { return jour; } }

        public NouveauJour(Evenement e)
        {
            InitializeComponent();
            this._evenement = e;

        }

        private void NouveauJour_Load(object sender, EventArgs e)
        {
            this.evenementsTableAdapter.Fill(this.PhotosDBDataSet.Evenements);
            Guid resultat = Guid.NewGuid();
            id.Text = resultat.ToString("D");
            evenement.SelectedIndex = evenement.Items.Count - 1;
            string idEv = evenement.SelectedValue.ToString();
            evenementsDataTable = evenementsTableAdapter.GetDataById(idEv);
            if (evenementsDataTable.Count > 0)
            {
                date.Value = (DateTime)evenementsDataTable.Rows[0]["Date"];
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

            string idEvenement = evenement.SelectedValue.ToString();
            foreach (EvenementsRow rowEvenement in this.PhotosDBDataSet.Evenements.Rows)
            {
                if (rowEvenement.Id == idEvenement)
                {
                    DateTime dte = rowEvenement.Date.Date;
                    int duree = rowEvenement.Duree;
                    DateTime dteFin = dte.AddDays(duree).Date;
                    if(date.Value >= dte && date.Value <= dte.AddDays(duree))
                    {
                        if(remarques.Text.Length > 0)
                        {
                            JoursRow row = PhotosDBDataSet.Jours.NewJoursRow();
                            row.Id = id.Text;
                            row.IdEvenement = evenement.SelectedValue.ToString();
                            row.Date = date.Value;
                            row.Commentaire = remarques.Text;
                            PhotosDBDataSet.Jours.AddJoursRow(row);

                            joursTableAdapter1.Update(PhotosDBDataSet);

                            // Initialise le champ Jour
                            jour = new Jour();
                            jour.Date = date.Value;
                            jour.Commentaire = remarques.Text;
                            jour.Id = id.Text;
                            jour.IdEvenement = _evenement.Id;
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
