using System;
using System.Collections.Generic;
using System.Text;

namespace Music
{
    public class Playlist
    {
        public List<User> Users { get; set; }
        public string PlaylistName { get; set; }
        public DateTime PlaylistDate { get; set; }
    }
}
