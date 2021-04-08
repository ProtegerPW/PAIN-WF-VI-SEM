using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;


namespace WF
{
    public partial class GenreControl : UserControl
    {
        [EditorAttribute(typeof(GenreEditor), typeof(System.Drawing.Design.UITypeEditor))]
        [BrowsableAttribute(true)]
        public enum genreBase
        {
            Pop,
            Rap,
            Rock
        }

        //store data about choosen genre    
        private genreBase genre;
        public genreBase Genre
        {
            get { return genre; }
            set { genre = value; }
        }

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

        public GenreControl(genreBase genre)
        {
            this.Genre = genre;
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


    public class GenreEditor : System.Drawing.Design.UITypeEditor
    {
        public GenreEditor()
        {

        }
        public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.DropDown;
        }

        // Displays the UI for value selection.
        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value)
        {
            /*// Return the value if the value is not of type Int32, Double and Single.
            if (value.GetType() != typeof(double) && value.GetType() != typeof(float) && value.GetType() != typeof(int))
                return value;*/

            // Uses the IWindowsFormsEditorService to display a 
            // drop-down UI in the Properties window.
            IWindowsFormsEditorService edSvc = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
            if (edSvc != null)
            {
                // Display an angle selection control and retrieve the value.
                GenreControl genreValue = new GenreControl((GenreControl.genreBase)value);
                edSvc.DropDownControl(genreValue);
            }
            return value;
        }

        // Draws a representation of the property's value.
        public override void PaintValue(System.Drawing.Design.PaintValueEventArgs e)
        {
            /*int normalX = (e.Bounds.Width / 2);
            int normalY = (e.Bounds.Height / 2);

            // Fill background and ellipse and center point.
            e.Graphics.FillRectangle(new SolidBrush(Color.DarkBlue), e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height);
            e.Graphics.FillEllipse(new SolidBrush(Color.White), e.Bounds.X + 1, e.Bounds.Y + 1, e.Bounds.Width - 3, e.Bounds.Height - 3);
            e.Graphics.FillEllipse(new SolidBrush(Color.SlateGray), normalX + e.Bounds.X - 1, normalY + e.Bounds.Y - 1, 3, 3);

            // Draw line along the current angle.
            double radians = ((double)e.Value * Math.PI) / (double)180;
            e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Red), 1), normalX + e.Bounds.X, normalY + e.Bounds.Y,
                e.Bounds.X + (normalX + (int)((double)normalX * Math.Cos(radians))),
                e.Bounds.Y + (normalY + (int)((double)normalY * Math.Sin(radians))));*/
        }

        // Indicates whether the UITypeEditor supports painting a 
        // representation of a property's value.
        public override bool GetPaintValueSupported(System.ComponentModel.ITypeDescriptorContext context)
        {
            return true;
        }
    }
}