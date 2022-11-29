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
            soundPlayer.SoundLocation = "D:/My Music/Trak1_projectMp3.wav";
            soundPlayer.Play();
            Console.ReadKey();
        }
        public static void TrackPlayer2()
        {
            SoundPlayer soundPlayer = new SoundPlayer();
            soundPlayer.SoundLocation = "D:/My Music/Trak2_projectMp3.wav";
            soundPlayer.Play();
            Console.ReadKey();
        }
           public static void TrackPlayer3()
        {
            SoundPlayer soundPlayer = new SoundPlayer();
            soundPlayer.SoundLocation = "D:/My Music/Trak3_projectMp3.wav";
            soundPlayer.Play();
            Console.ReadKey();
        }
    }
}