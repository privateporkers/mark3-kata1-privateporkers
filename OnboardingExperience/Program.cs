using System;

namespace OnboardingExperience
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and Welcome to Privateporkers National Bank");

            QuestionAnswer("What is your First name?", "Your first name is: ");

        }

        public static void QuestionAnswer(string question, string response)
        {
           Console.WriteLine(question);
          var read = Console.ReadLine();
          Console.WriteLine(response + read);
        }
    }
}
