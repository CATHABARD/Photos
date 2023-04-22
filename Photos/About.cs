
namespace Photos
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            textBoxNom.Text = Properties.Settings.Default.Nom;
            textBoxVersion.Text = Properties.Settings.Default.Version;
        }

        private void buttonFermer_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
