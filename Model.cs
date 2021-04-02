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
    public partial class Model : Form
    {
        private SongDoc Document { set; get; } = new SongDoc();
        public Model()
        {
            InitializeComponent();
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            View songView = new View(Document);
            songView.MdiParent = this;
            songView.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
