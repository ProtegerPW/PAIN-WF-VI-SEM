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


        private void View_Activated(object sender, EventArgs e)
        {
            ToolStripManager.Merge(viewStatusStrip, ((Model)MdiParent).modelStatusStrip);
            ToolStripManager.Merge(viewToolStrip, ((Model)MdiParent).modelToolStrip);
        }

        private void View_Deactivate(object sender, EventArgs e)
        {
            ToolStripManager.RevertMerge(((Model)MdiParent).modelStatusStrip, viewStatusStrip);
            ToolStripManager.RevertMerge(((Model)MdiParent).modelToolStrip, viewToolStrip);
        }
    }
}
