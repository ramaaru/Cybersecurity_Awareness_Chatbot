using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Runtime.Remoting.Channels;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Cybersecurity_Awareness_Chatbot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Play a welcome audio greeting when the chatbot starts
            AudioPlayer.PlayVoiceGreeting("welcome.wav");

            SoundPlayer player = new SoundPlayer(Cybersecurity_Awareness_Chatbot.Properties.Resources.welcome);
            player.Play();

            
            // Display a welcome image when the chatbot starts
            imageDisplay.DisplayWelcomeImage();
        }
    }  
}

