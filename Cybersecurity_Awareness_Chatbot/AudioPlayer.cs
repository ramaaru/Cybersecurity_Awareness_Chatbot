using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Cybersecurity_Awareness_Chatbot
{
    internal class AudioPlayer
    {
        public static void PlayVoiceGreeting(string filePath)
        {
            try
            {
                SoundPlayer player = new SoundPlayer(Cybersecurity_Awareness_Chatbot.Properties.Resources.welcome);
                player.PlaySync();
            }
            catch (Exception e)
            {
                Console.WriteLine("\n[Error] Unable to play the voice greeting. Make sure the file exists.");
                Console.WriteLine(e.Message);
            }
        }
    }
}

