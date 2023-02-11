using System;
using System.Collections.Generic;
using System.Text;

namespace Music
{
    public class Song
    {
        public List<Singer> Singers { get; set; }
        public List<User> Users { get; set; }
        public Composer Composer { get; set; }
        public Songwriter Songwriter { get; set; }
        public string SongName { get; set; }
        public string Genre { get; set; }

    }
}
