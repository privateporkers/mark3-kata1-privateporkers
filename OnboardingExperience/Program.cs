using System;
using System.Linq;

namespace OnboardingExperience
{
    class Program
   {
        static void Main(string[] args)
        {
            var user = new User();
            var gumby = new TermArt();

            Console.WriteLine("╔═══════════════════════════════════════════════╗");
            Console.WriteLine("Hello and Welcome to Privateporkers National Bank");
            Console.WriteLine("╚═══════════════════════════════════════════════╝");

            //asks the user for there first name then there last. Out putting both first and last name
            user.FirstName = AskQuestion("What is your first name?");
            user.LastName = AskQuestion("what is your last name?");
            Console.WriteLine($"You name is: {user.FirstName} {user.LastName}");
            Console.Clear();

            user.age = IntQuestion("What is your age?");
             Console.WriteLine($"Your age is: {user.age}");
        }
        public static string AskQuestion(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        public static int IntQuestion(string questionInt)
        {
            Console.WriteLine(questionInt);
            int num;

            while(!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("**ERROR** please insert a number instead");
            }

            return num;

        }
    }
}
