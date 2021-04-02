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
    public partial class View : Form
    {
        private SongDoc songList_ { set; get; }
        public View(SongDoc document)
        {
            InitializeComponent();
            songList_ = document;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
