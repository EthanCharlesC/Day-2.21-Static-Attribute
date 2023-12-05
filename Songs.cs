using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2._21_Static_Attribute
{
    internal class Songs
    {

        public string title;
        public string artist;
        public int duration;

        public static int songCount = 0;
        public Songs(string aTtile, string aArtist, int aDuration)
        {
            this.title = aTtile;    
            this.artist = aArtist;
            this.duration = aDuration;
            songCount++;
        }
    }
}
