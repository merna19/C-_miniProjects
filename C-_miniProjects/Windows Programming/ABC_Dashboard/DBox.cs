using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Dashboard
{
    public partial class DBox : Form
    {
        Form1 form1;
        Bitmap pixeledImg;
        Color pickedColor;

        public string New_Title
        {
            get
            {
                return (newTitle.Text);
            }
        }
        public string New_Font
        {
            get { return FontBox.Text; }

        }
        public Color New_Color
        {
            get { return pickedColor; }
        }

        public DBox()
        {
            InitializeComponent();
            form1 = new Form1();

            this.Shown += DBox_Shown;
            this.pictureBox1.MouseDown += pictureBox1_MouseDown;

            

        }
        private void OK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void DBox_Shown(object sender, EventArgs e)
        {
            // empty entry bug fixed
            this.OldTitle.Text = form1.TITLE;
            this.FontBox.Text = form1.TITLE_FONT.Name;
            pixeledImg = (Bitmap)pictureBox1.Image;
            pickedColor= form1.TITLE_COLOR;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Color colorHovered= pixeledImg.GetPixel(e.X,e.Y);
            label10.BackColor = colorHovered;
            label7.Text = colorHovered.R.ToString();//R
            label8.Text = colorHovered.G.ToString();//G
            label9.Text = colorHovered.B.ToString();//B
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pickedColor = pixeledImg.GetPixel(e.X,e.Y);
            label12.BackColor = pickedColor;
        }
    }
}
