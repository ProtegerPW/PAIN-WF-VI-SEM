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
        private SongDoc document = new SongDoc();
        public Model()
        {
            InitializeComponent();
        }

        private void NewViewFunction()
        {
            View songView = new View(document);
            songView.MdiParent = this;
            songView.Show();
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            NewViewFunction();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewViewFunction();
        }

        private void ExitProgramFunction()
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Dispose();
                child.Close();
            }
            Application.Exit();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            ExitProgramFunction();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitProgramFunction();
        }
    }
}
