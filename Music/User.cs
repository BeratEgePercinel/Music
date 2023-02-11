using System;
using System.Collections.Generic;
using System.Text;

namespace Music
{
    public class User
    {
        public List<Song> Songs { get; set; }
        public List<Playlist> Playlists { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
