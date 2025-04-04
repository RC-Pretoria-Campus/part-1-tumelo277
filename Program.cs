using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech; 
using System.Speech.Synthesis;
using System.IO;
using System.Media;
using System.Threading;

namespace Chatbot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer Voice = new SpeechSynthesizer();
            Voice.SelectVoiceByHints(VoiceGender.Male);
            Voice.Volume = 100;
            Voice.Rate = 5;
            //configure the speech synthesizer with a male voice, volume set to max and a speaking rate
            Voice.Speak("Hello! I am a cyber awareness chatbot. I'm here to help you stay safe online.");

            Image();
            //Console.Clear(); // Clears the console before starting
            Console.ForegroundColor = ConsoleColor.Cyan; // Change text color to cyan
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("Hello! I am a cyber awareness chatbot. I'm here to help you stay safe online.");
            Console.WriteLine("--------------------------------------------------------------------------------");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("What is your name?");
            // Ask the user for their name and store the input
            Console.ForegroundColor = ConsoleColor.White;
            String Name = Console.ReadLine();
            // Read user input and store it in the variable 'Name'

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ask me a question " + Name + " or type exit to end the chat");

            // Prompt the user to ask a question or type 'exit' to end the conversation
            Console.ForegroundColor = ConsoleColor.White;
            String Input = Console.ReadLine();
            // Read the user's input (the question or command) and store it in the 'Input' variable

            while (true)
            {
                // Start an infinite loop to keep the conversation going until 'exit' is typed
                Console.ForegroundColor = ConsoleColor.White;
                Input = Console.ReadLine().ToLower().Trim();
                // Read and process the user's input: convert it to lowercase and remove extra spaces

                if (Input == "exit")
                {
                    // If the user types 'exit', print a goodbye message and break the loop to end the program
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Exiting... Goodbye!");
                    Voice.Speak("Exiting... Goodbye!");
                    break;
                    // Exit the loop and end the program
                }

                if (Input != null)
                {
                    // If the user provided a valid input, process the input by calling the Speech method
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Speech(Input, Name);
                    //Speech method will process the input and speak it
                }
                else
                {
                    // If the input is empty prompt the user again
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sorry, I didn't catch that. Could you please enter something " + Name);
                    break;
                    // End the loop if no valid input was entered
                }
            }

        }
        
        static void Image()
        {
         
            string asciiLogo = @"
                    
  ___ __ ____ ____    ____ _  _  __ ____     ___ _  _  __ ____ 
 / __/  (    (  __)  (_  _/ )( \/ _(_  _)   / __/ )( \/ _(_  _)
( (_(  O ) D () _)     )( ) __ /    \)(    ( (__) __ /    \)(  
 \___\__(____(____)   (__)\_)(_\_/\_(__)    \___\_)(_\_/\_(__) 
";

            Console.WriteLine("------------------------------------------------------------------------------------------");
            Console.WriteLine(asciiLogo);
            Console.WriteLine("------------------------------------------------------------------------------------------");

            Console.ForegroundColor = ConsoleColor.Cyan; // Change text color to cyan
            Console.WriteLine("Welcome to the Cyber Chatbot!");
        }
        static void Speech(string Input, string Name) {
            // Display the chatbot’s response based on user input

            Console.ForegroundColor = ConsoleColor.Yellow;
            if (Input == "how are you?")
            {
                Console.WriteLine("i'm okay, thank you " + Name);
            }
            else if (Input == "what is your purpose?")
            {
                Console.WriteLine("to educate you about cybersecurity dangers and safety");
            }
            else if (Input == "what can i ask you about?")
            {
                Console.WriteLine("you can ask me about password safety, phishing attacks and safe browsing");
            }
            else if (Input == "what is password safety?")
            {
                Console.WriteLine("password safety is an important part of cybersecurity because, " +
                    "it helps keep networks, systems and accounts from unauthorised access." +
                    "You could implement it yourself by making   passwords 12 character long, unique and complex passwords" +
                    "that don't have any personal information");
            }
            else if (Input == "what is a phishing attack?")
            {
                Console.WriteLine("this is when criminals impersonate trusted entities to trick individuals" +
                    "to reveal sensitive information like card details or passwords. They usually do this using emails or text messages" +
                    "that contain links. To protect yourself you shoulf be weary of emails that ask for sensitive information," +
                    "verify the validy of a website before link before divulging infomation and use strong passwords");
            }
            else if (Input == "what is safe browsing?")
            {
                Console.WriteLine("what is the practices used to protect yourself from potential online threats" +
                    "and risks while browsing the internet. It protects you from malware, phishing, scams etc." +
                    "These practices include using a secure browser(such as Google Chrome, Mozilla Firefox or Microsft Edge ), " +
                    "keeping your software up to date, be caustious with links,and use strong passwords and enable two-factor authentication whenever possible");
            }
           
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sorry " + Name + " I don't have an answer to that, could you please rephrase or ask something else ? ");
                return;
            }
        }
        
    }
}


