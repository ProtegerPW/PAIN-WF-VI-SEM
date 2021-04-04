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
        private SongDoc songViewDoc { set; get; }
        public View(SongDoc document)
        {
            InitializeComponent();
            songViewDoc = document;
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

        private void AddSong_Click(object sender, EventArgs e)
        {
            AddForm newSongForm = new AddForm(null, songViewDoc.songList_ );
            if(newSongForm.ShowDialog() == DialogResult.OK)
            {
                Song newSong = new Song(newSongForm.SongTitle, newSongForm.SongAuthor, newSongForm.SongDate, newSongForm.SongGenre);
                songViewDoc.AddSong(newSong);
                ListViewItem item = new ListViewItem();
                item.Tag = newSong;
                UpdateItem(item);
                songListView.Items.Add(item);                
            }
        }

        private void UpdateItem (ListViewItem item)
        {
            Song newSong = (Song)item.Tag;
            while (item.SubItems.Count < 4)
                item.SubItems.Add(new ListViewItem.ListViewSubItem());
            item.SubItems[0].Text = newSong.Title;
            item.SubItems[1].Text = newSong.Author;
            item.SubItems[2].Text = newSong.Production.ToShortDateString();
            item.SubItems[3].Text = newSong.Genre;
        }

        private void UpdateItems()
        {
            songListView.Items.Clear();
            foreach(Song song in songViewDoc.songList_)
            {
                ListViewItem item = new ListViewItem();
                item.Tag = song;
                UpdateItem(item);
                songListView.Items.Add(item);
            }
        }

        private void View_Load(object sender, EventArgs e)
        {
            UpdateItems();
            songViewDoc.songAddedEv += ViewDoc_AddSongEvent;
        }

        private void ViewDoc_AddSongEvent(Song song)
        {
            ListViewItem item = new ListViewItem();
            item.Tag = song;
            UpdateItem(item);
            songListView.Items.Add(item);
        }
    }
}
