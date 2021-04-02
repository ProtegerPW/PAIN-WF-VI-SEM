using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF
{
    public class SongDoc
    {
        public List<Song> songList_ { get; set;} = new List<Song>();
        public event Action<Song> songAddedEv;
        public event Action<Song> songUpdatedEv;
        public event Action<Song> songDeletedEv;

        public void AddSong (Song demo)
        {
            songList_.Add(demo);
            songAddedEv.Invoke(demo);
        }

        public void UpdateSong (Song demo)
        { 
            songUpdatedEv.Invoke(demo);
        }

        public void DeleteSong (Song demo)
        {
            songList_.Remove(demo);
            songDeletedEv.Invoke(demo);
        }
    }
}
