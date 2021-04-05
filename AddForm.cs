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
    public partial class AddForm : Form
    {
        private Song song_;
        private List<Song> songList_;
        public AddForm(Song songToEdit, List<Song> songList)
        {
            InitializeComponent();
            this.song_ = songToEdit;
            this.songList_ = songList;
        }

        public string SongTitle
        {
            get { return titleTextBox.Text;  }
        }

        public string SongAuthor
        {
            get { return composerTextBox.Text;  }
        }

        public DateTime SongDate
        {
            get { return recordingDate.Value; }
        }

        public string SongGenre
        {
            get { return Enum.GetName(typeof(GenreControl.genreBase), genreControl.Genre); }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void titleTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!titleTextBox.Text.All(Char.IsLetterOrDigit))
            {
                e.Cancel = true;
                addFormErrorProvider.SetError(titleTextBox, "Title contains not alpha numerical characters");
            }
            
        }

        private void titleTextBox_Validated(object sender, EventArgs e)
        {
            addFormErrorProvider.SetError(titleTextBox, "");
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            if(song_ != null)
            {
                titleTextBox.Text = song_.Title;
                composerTextBox.Text = song_.Author;
                recordingDate.Value = song_.Production;
                genreControl.Genre = (GenreControl.genreBase) Enum.Parse(typeof(GenreControl.genreBase), song_.Genre, true);
            }
        }
    }
}
