using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Music
    {
        public string songName;
        public string songDuration;

        public Music(string songName, string songDuration)
        {
            this.songName = songName;
            this.songDuration = songDuration;
        }

        public override string ToString()
        {
            return $"{songName} ({songDuration})";
        }
    }
}