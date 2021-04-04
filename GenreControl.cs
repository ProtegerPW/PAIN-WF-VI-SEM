using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF
{
    /*public class GenreEditor : System.Drawing.Design.UITypeEditor
    {

    }*/
    public partial class GenreControl : UserControl
    {
        public genreBase Genre
        {
            get { return (genreBase)genre; }
            set { genre = value; }
        }
        public enum genreBase
        {
            Pop,
            Jazz,
            Rock
        }

        private genreBase genre;

        public GenreControl()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            /*Image image = Image.FromFile("Disque.png");*/
    

        }

        private void GenreControl_Load(object sender, EventArgs e)
        {
            Image image = Image.FromFile("D:\\Programowanie\\Visual\\WF\\WF\\Properties\\Disque.png");
            pictureBox1.Image = image;
            pictureBox1.Height = image.Height;
            pictureBox1.Width = image.Width;

        }
    }
}