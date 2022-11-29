using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Player
{
    class MusicPlayer
    {
        public static void TrackPlayer()
        {
            SoundPlayer soundPlayer = new SoundPlayer();
            soundPlayer.SoundLocation = "D:/Music/madiatrap ver2.wav";
            soundPlayer.Play();
            Console.ReadKey();
        }
    }
}