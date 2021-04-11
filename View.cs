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

        private void View_Load(object sender, EventArgs e)
        {
            filterComboBox.SelectedIndex = 0;
            //EditSong.Enabled = false;
            UpdateItems();
            CountItems();
            songViewDoc.songAddedEv += ViewDoc_AddSongEvent;
            songViewDoc.songUpdatedEv += ViewDoc_EditSongEvent;
            songViewDoc.songDeletedEv += ViewDoc_DeleteSongEvent; 
        }

        private bool CheckFilter (Song song)
        {
            switch(filterComboBox.SelectedIndex)
            {
                case 0:
                    return true;

                case 1:
                    return song.Production < new DateTime(2000, 1, 1);

                case 2:
                    return song.Production >= new DateTime(2000, 1, 1);

                default:
                    throw new Exception("Invalid filer");
            }
        }

        private void CountItems()
        {
            countItemsStatusLabel.Text = songListView.Items.Count.ToString();
            UpdateControls();
        }

        private void UpdateControls()
        {
            if (Int32.Parse(countItemsStatusLabel.Text) > 0)
            {
                EditSong.Enabled = true;
                DeleteSong.Enabled = true;
                EditSongMenuStrip.Enabled = true;
                DeleteSongMenuStrip.Enabled = true;
                EditContextMenuStrip.Enabled = true;
                DeleteContextMenuStrip.Enabled = true;

            }
            else
            {
                EditSong.Enabled = false;
                DeleteSong.Enabled = false;
                EditSongMenuStrip.Enabled = false;
                DeleteSongMenuStrip.Enabled = false;
                EditContextMenuStrip.Enabled = false;
                DeleteContextMenuStrip.Enabled = false;
            }
        }

        private void UpdateItem(ListViewItem item)
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
            foreach (Song song in songViewDoc.songList_)
            {
                if (CheckFilter(song))
                {
                    ListViewItem item = new ListViewItem();
                    item.Tag = song;
                    songListView.Items.Add(item);
                    UpdateItem(item);
                }
            }
        }

        private void AddSongFunction()
        {
            AddForm newSongForm = new AddForm(null, songViewDoc.songList_);
            if (newSongForm.ShowDialog() == DialogResult.OK)
            {
                Song newSong = new Song(newSongForm.SongTitle, newSongForm.SongAuthor, newSongForm.SongDate, newSongForm.SongGenre);
                songViewDoc.AddSong(newSong);
            }
        }

        private void AddSong_Click(object sender, EventArgs e)
        {
            AddSongFunction();
        }

        private void AddSongMenuStrip_Click(object sender, EventArgs e)
        {
            AddSongFunction();
        }

        private void AddContextMenuStip_Click(object sender, EventArgs e)
        {
            AddSongFunction();
        }

        private void ViewDoc_AddSongEvent(Song song)
        {
            if(CheckFilter(song))
            {
                ListViewItem item = new ListViewItem();
                item.Tag = song;
                UpdateItem(item);
                songListView.Items.Add(item);
                CountItems();
            }
            
        }

        private void EditSongFunction()
        {
            if (songListView.SelectedItems.Count == 0)
                return;
            Song song = (Song)songListView.SelectedItems[0].Tag;
            AddForm editSongForm = new AddForm(song, songViewDoc.songList_);

            if (editSongForm.ShowDialog() == DialogResult.OK)
            {
                Song newSong = new Song(editSongForm.SongTitle, editSongForm.SongAuthor, editSongForm.SongDate, editSongForm.SongGenre);
                songViewDoc.UpdateSong(song, newSong);
            }
        }

        private void EditSong_Click(object sender, EventArgs e)
        {
            EditSongFunction();
        }

        private void EditSongMenuStrip_Click(object sender, EventArgs e)
        {
            EditSongFunction();
        }

        private void EditContextMenuStrip_Click(object sender, EventArgs e)
        {
            EditSongFunction();
        }

        private void ViewDoc_EditSongEvent(Song oldSong, Song newSong)
        {
            foreach (ListViewItem item in songListView.Items)
                if (ReferenceEquals(item.Tag, oldSong))
                {
                    item.SubItems[0].Text = newSong.Title;
                    item.SubItems[1].Text = newSong.Author;
                    item.SubItems[2].Text = newSong.Production.ToShortDateString();
                    item.SubItems[3].Text = newSong.Genre;
                    item.Tag = newSong;
                    return;
                }

        }

        private void DeleteSongFunction()
        {
            ListViewItem item = songListView.SelectedItems[0];
            songListView.Items.Remove(item);
            CountItems();
            Song song = (Song)item.Tag;
            songViewDoc.DeleteSong(song);
            songViewDoc.songDeletedEv += ViewDoc_DeleteSongEvent;
        }

        private void DeleteSong_Click(object sender, EventArgs e)
        {
            DeleteSongFunction();
        }

        private void DeleteSongMenuStrip_Click(object sender, EventArgs e)
        {
            DeleteSongFunction();
        }

        private void DeleteContextMenuStrip_Click(object sender, EventArgs e)
        {
            DeleteSongFunction();
        }

        private void ViewDoc_DeleteSongEvent(Song song)
        {
            foreach (ListViewItem item in songListView.Items)
                if (ReferenceEquals(item.Tag, song))
                {
                    songListView.Items.Remove(item);
                    CountItems();
                    return;
                }
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

        private void filterComboBox_DropDownClosed(object sender, EventArgs e)
        {
            UpdateItems();
            CountItems();
        }

        private void View_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MdiParent.MdiChildren.Count() == 1)
            {
                e.Cancel = true;
            } else
            {
                e.Cancel = false;
            } 
        }       
    }
}
