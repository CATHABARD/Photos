using Photos.Modeles;
using Photos.Services;
using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Photos
{
    public partial class Carousel : Form
    {
        private PhotosService photosService;
        private List<Photo>? listePhotos;
        private Jour? jour;
        private Point positionCentrale;
        private int indexPhotoCourante = -1;
        private PictureBox[] pictureBox;
        readonly PhotosDbContext _context;

        private int x = 0;

        public Carousel(PhotosDbContext context)
        {
            _context = context;
            InitializeComponent();
            photosService = new PhotosService(_context);
            pictureBox = new PictureBox[2];
        }

        public DialogResult ShowDialog(Jour jour)
        {
            this.jour = jour;
            listePhotos = photosService.GetPhotosJour(this.jour);
            indexPhotoCourante = 0;

            pictureBox[0] = new PictureBox();
            pictureBox[0].SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox[0].BackColor = System.Drawing.SystemColors.WindowFrame;
            pictureBox[0].Name = "pictureBox1";
            pictureBox[0].TabStop = false;
            pictureBox[0].TabIndex = 0;
            pictureBox[0].Location = new Point(0,0);
            pictureBox[0].Size = new Size((int)(panel1.Width / 1.2), panel1.Height);

            pictureBox[1] = new PictureBox();
            pictureBox[1].SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox[1].BackColor = System.Drawing.SystemColors.WindowFrame;
            pictureBox[1].Name = "pictureBox2";
            pictureBox[1].TabStop = false;
            pictureBox[1].TabIndex = 0;
            pictureBox[1].Size = new Size((int)(panel1.Width / 1.2), panel1.Height);

            panel1.Controls.Add(pictureBox[0]);
            panel1.Controls.Add(pictureBox[1]);

            InitPictureBox();

            Avance();

            return base.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Avance();
        }

        private void Avance()
        {
            timer2.Start();
            return;
        }

        private void InitPictureBox()
        {
            Image img1 = null, img2 = null;
            try
            {
                this.nSurM.Text = (indexPhotoCourante + 1).ToString() + " sur " + listePhotos.Count.ToString();

                string path1 = (listePhotos[indexPhotoCourante] as Photo).Adresse;
                img1 = Image.FromFile(path1);
                img1.GetPropertyItem(20624);
                if(indexPhotoCourante < listePhotos.Count - 1)
                {
                    string path2 = (listePhotos[indexPhotoCourante + 1] as Photo).Adresse;
                    img2 = Image.FromFile(path2);
                }
                this.positionCentrale = new Point((panel1.Width - pictureBox[0].Width) / 2, 0);
                pictureBox[0].Location = new Point(this.positionCentrale.X, 0);
                pictureBox[1].Location = new Point(panel1.Width, 0);
                pictureBox[0].Image = img1;
                if(img2 != null)
                    pictureBox[1].Image = img2;
            }
            catch(FileNotFoundException ex) {
                MessageBox.Show(ex.Message);
                return;
            }

            return;
        }

        private bool ThumbnailCallback()
        {
            return false;
        }


        private bool MovePictureBox(int x)
        {
            pictureBox[0].Location = new Point(this.positionCentrale.X - x, this.positionCentrale.Y);
            pictureBox[1].Location = new Point(panel1.Width - x, 0);
            if(pictureBox[1].Location.X <= positionCentrale.X)
            {
                this.x = 0;

                return false;
            }
            return true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(!MovePictureBox(x += 10))
            {
                indexPhotoCourante++;
                if (indexPhotoCourante >= listePhotos.Count)
                    indexPhotoCourante = 0;
                timer2.Stop();
                InitPictureBox();
                timer1.Start();
            }
        }
    }
}
