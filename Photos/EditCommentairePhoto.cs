using System.Windows.Forms;

namespace Photos
{
    public partial class EditCommentairePhoto : Form
    {
        private string commentaire;
        public string Commentaire { get => commentaire; }
        public string Path { set => path = value; }
        private string path;

        public EditCommentairePhoto()
        {
            commentaire = String.Empty;
            path = String.Empty;
            InitializeComponent();
        }

        public DialogResult ShowDialog(string commentaire)
        {
            DossierTextBox.Text = path;
            this.commentaire = commentaire;
            textBoxCommentaire.Text = this.Commentaire;

            return base.ShowDialog();
        }

        private void ButtonAnnuler_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void ButtonValider_Click(object sender, System.EventArgs e)
        {
            this.commentaire = textBoxCommentaire.Text.Trim();
            Close();
        }
    }
}
