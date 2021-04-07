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
            get { return genre; }
            set { genre = value; }
        }
        public enum genreBase
        {
            Pop,
            Rap,
            Rock
        }

        //store data about choosen genre    
        private genreBase genre;
        public List<String> genreImages = new List<String>(new string[]
        {
            "D:\\Programowanie\\Visual\\WF\\WF\\Properties\\logo1_.png",
            "D:\\Programowanie\\Visual\\WF\\WF\\Properties\\logo2_.png",
            "D:\\Programowanie\\Visual\\WF\\WF\\Properties\\logo3_.png"
        });

        public GenreControl()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int index = (int)Genre;
            if (index == Enum.GetNames(typeof(genreBase)).Length - 1)
            {
                index = 0;
                genre = (genreBase)index;
            } else
            {
                index++;
                genre = (genreBase)index;
            }
            Image image = Image.FromFile(genreImages[index]);
            pictureBox1.Image = image;
            pictureBox1.Invalidate();
        }

        private void GenreControl_Load(object sender, EventArgs e)
        {
            int index = (int)Genre;
            Image image = Image.FromFile(genreImages[index]);
            pictureBox1.Image = image;
            pictureBox1.Invalidate();
        }
    }
}