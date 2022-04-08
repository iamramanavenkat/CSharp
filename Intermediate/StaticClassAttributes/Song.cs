using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassAttributes
{
    class Song
    {
        public string title;
        public string artist;
        public int duration;  //in seconds
        public static int songCount = 0;

        public Song(string aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            songCount++;  // Incremented whenever the class "Song" is created
        }
        public int getSongCount()
        {
            return songCount;
        }


    }
}
