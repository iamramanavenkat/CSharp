using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassAttributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Song lovely = new Song("Lovely", "Billie Eilish", 200);
            Console.WriteLine(Song.songCount);
            Song levitating = new Song("Levitating", "Dua Lipa", 203);
            Console.WriteLine(levitating.artist);
            Console.WriteLine(Song.songCount);
            Console.WriteLine(levitating.getSongCount());
            Console.Read();
        }
    }
}
