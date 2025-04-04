using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chatbot
{
    internal class PlayAudio
    {

        public static void Voice()
        {
            //string audioFilePath = Path.Combine("Tumelo(1).wav");
            // This is the path to the audio file
            try
            {
                // using (
                SoundPlayer player = new SoundPlayer("Tumelo(3).wav");
                player.Load();
                // Loading the audio file
                player.PlaySync();
                 
                 Thread.Sleep(3000); // Delay to allow the sound to finish
             }
             catch (Exception ex)
             {
                 Console.Write(" Error playing audio: " + ex.Message, ConsoleColor.Red);
                 Console.ResetColor();
             }
            
        }
    }
}
