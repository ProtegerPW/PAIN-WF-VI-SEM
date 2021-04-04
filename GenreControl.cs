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

        //store data about choosen genre    
        private genreBase genre;
        private List<String> genreImages = new List<String>(new string[]
        {
            "D:\\Programowanie\\Visual\\WF\\WF\\Properties\\Disque.png",
            "D:\\Programowanie\\Visual\\WF\\WF\\Properties\\logo2.png",
            "D:\\Programowanie\\Visual\\WF\\WF\\Properties\\logo3.png"
        });

        public GenreControl()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int index = (int)genre;
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
            genre = (genreBase)0;
            Image image = Image.FromFile(genreImages[0]);
            pictureBox1.Image = image;           
        }
    }
}