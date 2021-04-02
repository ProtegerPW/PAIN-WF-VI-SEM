using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF
{
    public class Song
    {
        public String Title
        {
            get;
            set;
        }

        public String Author
        {
            get;
            set;
        }

        public DateTime Production
        {
            get;
            set;
        }

        public String Type
        {
            get;
            set;
        }

        public Song( String title, String author, DateTime production, String type)
        {
            Title = title;
            Author = author;
            Production = production;
            Type = type;
        }
    }
}
