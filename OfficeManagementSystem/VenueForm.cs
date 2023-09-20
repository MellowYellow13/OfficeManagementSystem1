using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfficeManagementSystem
{
    public partial class VenueForm : Form
    {
        public VenueForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                layoutDiagramPictureBox.Image = new Bitmap(openFileDialog1.FileName);
            }
        }
    }
