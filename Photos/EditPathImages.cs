using Photos.Modeles;
using Photos.Services;

namespace Photos
{
    public partial class EditPathImages : Form
    {
        private string selectedPath = String.Empty;
        public string SelectedPath { get { return selectedPath; } set { selectedPath = value; } }
        readonly ParamsService paramsService;
        readonly PhotosDbContext _context;

        public EditPathImages(string path, PhotosDbContext context)
        {
            _context = context;
            InitializeComponent();
            paramsService = new (_context);
            selectedPath = path.Trim();
            emplacementActueltextBox.Text = selectedPath;
        }

        private new DialogResult ShowDialog()
        {
            return ShowDialog();
        }

        private void DefinitEmplacementButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    selectedPath = fbd.SelectedPath;
                    EmplacementChoisiTextBox.Text = selectedPath;
                }
            }
        }

        private void ValiderButton_Click(object sender, EventArgs e)
        {
            Param param = paramsService.GetParam("PathImages");
            param.Valeur = selectedPath;
            paramsService.UpdateParam(param);
        }
    }
}
