using Photos.Modeles;
using Photos.Services;

namespace Photos
{
    public partial class PhotoControl : UserControl
    {
        private readonly Photo photo;
        private readonly PhotosService photosService;
        public delegate void Modifie(object sender, ModifiePhotoEventArgs e);                                        
        public event Modifie? modifie;
        public delegate void Zoom(object sender, ZoomPhotoEventArgs e);
        public event Zoom zoom;
        readonly PhotosDbContext _context;

        public PhotoControl(PhotosDbContext context, Photo p)
        {
            _context = context;
            InitializeComponent();
            photosService = new(_context);

            photo = p;
            try
            {
                if(pictureBox1.Image != null)
                    pictureBox1.Image.Dispose();

                using (FileStream fs = new FileStream(photo.Adresse, FileMode.Open, FileAccess.Read))
                {
                    pictureBox1.Image = Image.FromFile(photo.Adresse).GetThumbnailImage(0, 0, ThumbnailCallback, IntPtr.Zero);
                }
            }
            catch (System.IO.FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            date.Text = photo.Heure.ToShortDateString() + " " + photo.Heure.ToShortTimeString();
            texte.Text = photo.Commentaire;
        }

        private bool ThumbnailCallback()
        {
            return false;
        }

        private void ButtonEditer_Click(object sender, EventArgs e)
        {
            using (EditCommentairePhoto edit = new EditCommentairePhoto())
            {
                edit.Path = photo.Adresse;
                if(edit.ShowDialog(texte.Text) == DialogResult.OK)
                {
                    string c = edit.Commentaire;
                    photo.Commentaire = c;
                    photosService.UpdatePhoto(photo);
                    modifie?.Invoke(this, new ModifiePhotoEventArgs(photo));
                    this.texte.Text = c;
                }
            }
        }

        private void ButtonSupprimer_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirmez-vous vouloir supprimer cette photo de la liste ?", "Supprimer la photo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                photosService.DeteletePhoto(photo);
                modifie?.Invoke(this, new ModifiePhotoEventArgs(photo));
                this.Dispose();
            }
        }

        /// <summary>
        /// Répond à l'évènement Click sur une image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">ZoomPhotoEventArgs objet Photo</param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (ZoomPhoto zf = new ZoomPhoto(photo.Adresse))
            {
                zf.ShowDialog();
            }
        }
    }

    public class ModifiePhotoEventArgs : System.EventArgs
    {
        public Photo photo;
        public ModifiePhotoEventArgs(Photo p)
        {
            photo = p;
        }
    }

    public class ZoomPhotoEventArgs : System.EventArgs
    {
        public Photo photo;
        public ZoomPhotoEventArgs(Photo p)
        {
            photo = p;
        }
    }

}

