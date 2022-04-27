using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    public partial class Cell : PictureBox
    {
        private int imgID;
        private Image img;

        public int ImgID
        {
            get { return imgID; }
            set 
            { 
                imgID = value; 
                img = (Image) Properties.Resources.ResourceManager.GetObject("_"+value.ToString());
                this.Image = img;
            }
        }

        public Image Img
        {
            get { return img; }
            set { this.Image = img; }
        }

        public Cell()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.BackColor = Color.LightSeaGreen;
        }
    }
}
