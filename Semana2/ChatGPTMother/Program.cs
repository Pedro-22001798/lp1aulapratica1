using System;

    public class Program
    {
        public static void Main()
        {
            string question = Console.ReadLine();
            while(question != "EXIT")
            {
                string response = question switch
                {
                    "What's your name?" => "My name is ChatGPTMother.",
                    "Who is your son?" => "My son is ChatGPT",
                    "Do you work for the FBI?" => "Cmon you know I am...",
                    _ => "I don't recognize that question, sorry :(",
                };
                Console.WriteLine(response);
                question = string.Empty;
                question = Console.ReadLine();
            }
        }
    }