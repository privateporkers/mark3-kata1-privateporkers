using System;

namespace OnboardingExperience
{
    class Program
   {
       
        static void Main(string[] args)
        {
            var user = new User();

            Console.WriteLine("Hello and Welcome to Privateporkers National Bank");

            //asks the user for there first name then there last. Out putting both first and last name
            user.FirstName = AskQuestion("What is your first name?");
            user.LastName = AskQuestion("what is your last name?");
            Console.WriteLine($"You name is: {user.FirstName} {user.LastName}");
            Console.Clear();




        }

        
        public static string AskQuestion(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();

        }
    }
}
