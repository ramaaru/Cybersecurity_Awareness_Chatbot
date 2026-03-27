using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cybersecurity_Awareness_Chatbot
{
    // Handles chatbot interactions, user input, and responses.
    internal class ChatBot
    {

        public string UserName { get; set; }

        // Typing effect (for better UI marks)
        private void TypeEffect(string message)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(15);
            }
            Console.WriteLine();
        }
       // Shows chatbot ASCII logo and title.
        public void ShowLogo()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("=========================================");
            Console.WriteLine("      CYBERSECURITY AWARENESS BOT        ");
            Console.WriteLine("=========================================");

            Console.WriteLine(@"
 ██████╗██╗   ██╗██████╗ ███████╗███████╗███████╗████████╗██╗   ██╗██████╗  ██████╗ ████████╗
██╔════╝██║   ██║██╔══██╗██╔════╝██╔════╝██╔════╝╚══██╔══╝██║   ██║██╔══██╗██╔═══██╗╚══██╔══╝
██║     ██║   ██║██████╔╝███████╗█████╗  █████╗     ██║   ██║   ██║██████╔╝██║   ██║   ██║
██║     ██║   ██║██╔═══╝ ╚════██║██╔══╝  ██╔══╝     ██║   ██║   ██║██╔═══╝ ██║   ██║   ██║
╚██████╗╚██████╔╝██║     ███████║███████╗███████╗   ██║   ╚██████╔╝██║     ╚██████╔╝   ██║
 ╚═════╝ ╚═════╝ ╚═╝     ╚══════╝╚══════╝╚══════╝   ╚═╝    ╚═════╝ ╚═╝      ╚═════╝    ╚═╝
");
            Console.ResetColor();
        }
        
         // Starts the chatbot and continues taking user input until exit.
        public void StartChat()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Enter your name: ");
            Console.ResetColor();

            UserName = Console.ReadLine();
              // Default name if user enters nothing
            if (string.IsNullOrWhiteSpace(UserName))
            {
                UserName = "User";
            }

            Console.ForegroundColor = ConsoleColor.Green;
            TypeEffect($"Hello {UserName}! 👋");
            TypeEffect("I'm here to help you stay safe online.");
            TypeEffect("Type 'help' to see what you can ask me.\n");
            Console.ResetColor();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\nYou: ");
                Console.ResetColor();

                string input = Console.ReadLine()?.ToLower();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Bot: Please enter a valid question.");
                    Console.ResetColor();
                    continue;
                }

                Respond(input);
            }
        }
        // Handles chatbot replies based on keywords in the user's input.
        private void Respond(string input)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            if (input.Contains("how are you"))
            {
                TypeEffect("Bot: I'm doing great! Ready to help you stay safe online.");
            }
            else if (input.Contains("purpose"))
            {
                TypeEffect("Bot: My purpose is to teach cybersecurity awareness and protect users like you.");
            }
            else if (input.Contains("help") || input.Contains("examples") || input.Contains("what can you"))
            {
                TypeEffect("Bot: You can ask me:");
                TypeEffect("- What is cybersecurity?");
                TypeEffect("- How do I create a strong password?");
                TypeEffect("- What is phishing?");
                TypeEffect("- How do I stay safe online?");
                TypeEffect("- What is 2FA?");
                TypeEffect("- safe browsing");

                TypeEffect("Type 'exit' to quit.");
            }
            else if (input.Contains("what is cybersecurity") || input.Contains("define cybersecurity"))
            {
                TypeEffect("Bot: Cybersecurity is the practice of protecting digital systems, " +
                    "networks, and data from cyberattacks, ensuring confidentiality, integrity, and availability of information.");
            }
            else if (input.Contains("password"))
            {
                TypeEffect("Bot:To create a strong password use long, unique, and combines letters, numbers, and " +
                    "symbols to resist guessing or brute-force attacks. ");
            }
            else if (input.Contains("phishing"))
            {
                TypeEffect("Bot:Phishing is a cyberattack where attackers use fake messages or " +
                    "websites to trick victims into giving away sensitive information. It works like “fishing,”" +
                    " using bait to lure targets into clicking harmful links or entering confidential data. ");
            }
            else if (input.Contains("malware") || input.Contains("virus") || input.Contains("ransomware"))
            {
                TypeEffect("Bot: Malware is malicious software designed to disrupt, damage, or " +
                    "gain unauthorized access to computer systems, networks, or devices.. Always use antivirus and keep your system updated.");
            }
            else if (input.Contains("safe browsing") || input.Contains("stay safe"))
            {
                TypeEffect("Bot: Safe browsing is the practice of navigating the internet securely to" +
                    " protect your devices, personal information, and identity from cyber threats.");
            }
            else if (input.Contains("two-factor") || input.Contains("2fa") || input.Contains("multi-factor"))
            {
                TypeEffect("Bot: 2FA adds an extra layer of security using a second verification step.");
            }
            else if (input.Contains("exit"))
            {
                TypeEffect($"Bot: Goodbye {UserName}! Stay safe online 🔒");
                Console.ResetColor();
                Environment.Exit(0);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                TypeEffect("Bot: I didn't understand that. Try typing 'help'.");
            }

            Console.ResetColor();

        }
    }
}
