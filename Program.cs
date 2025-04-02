using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech; 
using System.Speech.Synthesis;

namespace Chatbot
{
    internal class Program
    {
        
        private SpeechSynthesizer SpeechSyn;
       
        static void Main(string[] args)
        {
            Image();
            var SpeechSyn = new SpeechSynthesizer();
            SpeechSyn.Speak("Hello! Welcome to the cyber awareness Bot. I'm here to help you stay safe online.");

            Console.WriteLine("What is your name?");
            String Name = Console.ReadLine();
            
            Console.Write("Ask me a question " + Name); 
            Console.WriteLine(" or type exit to end the chat");
            String Input = Console.ReadLine();

            while (true)
            {
                 Input = Console.ReadLine().ToLower().Trim();  
                
                if (Input == "exit")
                {
                    Console.WriteLine("Exiting... Goodbye!");
                    break;
                }
              
                if (Input != null)
                {
                    Speech(Input, Name);
                }
                else
                {
                    Console.WriteLine("Sorry, I didn't catch that. Could you please enter something " + Name);
                    break;  
                }
            }
        }
        static void Image()
        {
            string asciiLogo = @"
  ____ _                 _     _____ _           _   
 / ___| | ___   ___   __| | __|_   _| |__   __ _| |_ 
| |   | |/ _ \ / _ \ / _` |/ _ \| | | '_ \ / _` | __|
| |___| | (_) | (_) | (_| |  __/| | | | | | (_| | |_ 
 \____|_|\___/ \___/ \__,_|\___| |_| |_| |_|\__,_|\__|
                                                     
             ____ _           _     
            / ___| |__   __ _| |_   
           | |   | '_ \ / _` | __|  
           | |___| | | | (_| | |_   
            \____|_| |_|\__,_|\__|  
             ";

            Console.WriteLine(asciiLogo);

            Console.WriteLine("Welcome to the Cyber Chatbot!");
        }
        static void Speech(string Input, string Name) {
            if (Input == "how are you?")
            {
                Console.WriteLine("I'm okay, thank you " + Name);
            }
            else if (Input == "What is your purpose?")
            {
                Console.WriteLine("To educate you about cybersecurity dangers and safety");
            }
            else if (Input == "What can I ask you about?")
            {
                Console.WriteLine("You can ask me about password safety, phishing attacks and safe browsing");
            }
            else if (Input == "What is password safety?")
            {
                Console.WriteLine("Password safety is an important part of cybersecurity because, " +
                    "it helps keep networks, systems and accounts from unauthorised access." +
                    "You could implement it yourself by making   passwords 12 character long, unique and complex passwords" +
                    "that don't have any personal information");
            }
            else if (Input == "What is a phishing attack?")
            {
                Console.WriteLine("This is when criminals impersonate trusted entities to trick individuals" +
                    "to reveal sensitive information like card details or passwords. They usually do this using emails or text messages" +
                    "that contain links. To protect yourself you shoulf be weary of emails that ask for sensitive information," +
                    "verify the validy of a website before link before divulging infomation and use strong passwords");
            }
            else if (Input == "What is safe browsing?")
            {
                Console.WriteLine("That is the practices used to protect yourself from potential online threats" +
                    "and risks while browsing the internet. It protects you from malware, phishing, scams etc." +
                    "These practices include using a secure browser(such as Google Chrome, Mozilla Firefox or Microsft Edge ), " +
                    "keeping your software up to date, be caustious with links,and use strong passwords and enable two-factor authentication whenever possible");
            }
           
            else
            {
                Console.WriteLine("Sorry " + Name + " I don't have an answer to that, could you please rephrase or ask something else ? ");
                return;
            }
        }

    }
}
