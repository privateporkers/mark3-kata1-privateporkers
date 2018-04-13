using System;
using System.Linq;

namespace OnboardingExperience
{
    class Program
   {
        static void Main(string[] args)
        {
            var user = new User();
            Console.WriteLine(@"
                      _.-,
         __.'   |   .,
       ,'_   _  | :` ;
       |'_` '_`|' : ,'
       |(o) (o)|  ; ;
       `|  A  |'  ; ;
     _..| `-' |..'.'
   .'.--.     .--'
 .'.'   |     |
 | :    |     |
 : |    |     |
 `.`.   ;     :
   `'   Y  .  Y
        |  |  |
        |  |  |
        ;  |  :
       /   |   \
      ;    |    :
     /_____|_____\
            ");
            Console.WriteLine("╔═══════════════════════════════════════════════╗");
            Console.WriteLine("Hello and Welcome to Privateporkers National Bank");
            Console.WriteLine("╚═══════════════════════════════════════════════╝");

            user.AcountOwner = IsAccountOwner("Are you the account owner? ");

            user.Pin = PinLogin();
            user.FirstName = AskQuestion("What is your first name?");
            user.LastName = AskQuestion("what is your last name?");
            user.Age = IntQuestion("What is your age?");

            Console.WriteLine($"You name is: {user.FirstName} {user.LastName} and your age is: {user.Age}");
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

        public static int PinLogin()
       {

            var pin = IntQuestion("What is your Pin: ");
            var pinConfirm = IntQuestion("Confirm your pin: ");

            while(pinConfirm != pin)
            {
                Console.WriteLine("The pins do not match, please try again");
            }

            return pinConfirm;

        }

        public static bool  IsAccountOwner(string answer)
        {
            var AccountAnswer = AskQuestion("Are you the account owner? (y/n)");

            if(AccountAnswer == "y"){
                return true;
            }
            else if(AccountAnswer == "n"){
                return false;
            }
            else{
                while(AccountAnswer != "y" || AccountAnswer!= "n"){
                    Console.WriteLine("Error: please type y or n");
                }
            }

               return true;

        }
    }
}
