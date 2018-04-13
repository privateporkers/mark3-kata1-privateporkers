using System;
using System.Linq;

namespace OnboardingExperience
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.BackgroundColor = ConsoleColor.Blue;
            //Console.ForegroundColor = ConsoleColor.Green;
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

            user.FirstName = AskQuestion("What is your first name?");
            user.LastName = AskQuestion("what is your last name?");
            user.Age = IntQuestion("What is your age?");
            user.Pin = PinLogin();

            Console.WriteLine($"You name is: {user.FirstName} {user.LastName} and your age is: {user.Age}");

            ExtraInfo();
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

            while(true)
              {
                var pin = IntQuestion("What is your Pin: ");
                var pinConfirm = IntQuestion("Confirm your pin: ");
                if(pinConfirm != pin)
                    {
                        Console.WriteLine("The pins do not match, please try again");
                        continue;
                    }
                else if(pinConfirm == pin)
                    return pinConfirm;
              }

        }

        public static bool  IsAccountOwner(string answer)
        {
            while(true)
            {
                var AccountAnswer = AskQuestion("Are you the account owner? (y/n)");
                if(AccountAnswer == "y"){return true;}
                else if(AccountAnswer == "n"){return false;}

                else{Console.WriteLine("ERROR: please type either 'y' or 'n' ");}
            }


        }

        public static void ExtraInfo()
        {
            Console.Clear();
            Console.WriteLine("Now That were done with the General information, lets get some");
            AskQuestion("What is your mothers maden name?");
            AskQuestion("Alrighty, now what is your social security number?");
            AskQuestion("Confirm your social security");
            Console.WriteLine("Now we have everything, so uuuh, we'll be back in touch soon...");


        }
    }
}
