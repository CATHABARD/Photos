using System;
using System.Drawing;
using System.Windows.Forms;

namespace Photos
{
    public partial class ZoomPhoto : Form
    {
        public ZoomPhoto(string path)
        {
            InitializeComponent();
            try
            {
                pictureBox1.Image = Image.FromFile(path);
            }
            catch(OutOfMemoryException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
