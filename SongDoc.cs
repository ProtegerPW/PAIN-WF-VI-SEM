using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF
{
    public class SongDoc
    {
        public List<Song> songList_ = new List<Song>();

        public event Action<Song> songAddedEv;
        public event Action<Song, Song> songUpdatedEv;
        public event Action<Song> songDeletedEv;

        public void AddSong (Song newSong)
        {
            songList_.Add(newSong);
            songAddedEv?.Invoke(newSong);
        }

        public void UpdateSong (Song oldSong, Song newSong)
        {
            songList_[songList_.IndexOf(oldSong)] = newSong;
            songUpdatedEv?.Invoke(oldSong, newSong);
        }

        public void DeleteSong (Song editSong)
        {
            songList_.Remove(editSong);
            songDeletedEv?.Invoke(editSong);
        }
    }
}
