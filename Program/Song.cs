using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Song
    {

        public string Title { get; set; }

        public string Artist { get; set; }

        public double Duration { get; set; }

        public Genre MusicGenre { get; set; }

    }

    public enum Genre{Rock, Pop,Dance, Other }
}
