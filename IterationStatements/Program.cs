namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void FirstChallenge()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        public static void SecondChallenge()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not

        public static void ThirdChallenge()
        {

            Console.WriteLine("Are your Numbers equal? Enter two of them!");
            int first = Convert.ToInt32(Console.ReadLine());
            int second = Convert.ToInt32(Console.ReadLine());

            if (first == second)
            {
                Console.WriteLine("True!");
            }
            else
            {
                Console.WriteLine("False!");
            }

        }

        //Write a method to check whether a given number is even or odd

        public static void FourthChallenge()
        {
            Console.WriteLine("Are your numbers event or odd? Enter your number!");

            int num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 % 2 == 0)
            {
                Console.WriteLine(num1 + " is even!");
            }
            else
            {
                Console.WriteLine(num1 + " is odd!");
            }
        }

        //Write a method to check whether a given number is positive or negative

        public static void FifthChallenge()
        {
            Console.WriteLine("Is your number positive or negative? Enter your number!");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("You are Positive!");
            }
            else
            {
                Console.WriteLine("You are Negative Ghostrider.");
            }
        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        public static void SixthChallenge()
        {
            Console.WriteLine("Are you old enough to vote? Enter your age");
            int age = int.Parse(Console.ReadLine());

            if (age >= 18)
            { Console.WriteLine("Welcome to the Voting Booth"); }
            else
            {
                Console.WriteLine("Go home kid");
            }


        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        public static void SeventhChallenge()
        { 
        Console.WriteLine("Enter an integer:");

        int number = Convert.ToInt32(Console.ReadLine());

        if (IsInRange(number, -10, 10))
        {
            Console.WriteLine($"{number} is in the range of -10 to 10.");
        }
        else
        {
            Console.WriteLine($"{number} is NOT in the range of -10 to 10.");
        }
    }

    public static bool IsInRange(int number, int min, int max)
{
    return number >= min && number <= max;
}

//Write a method to display the multiplication table(from 1 to 12) of a given integer

        public static void EighthChallenge()
        {
            Console.WriteLine("Hey, do you want to know the multiplication table of your number from 1 to 12? Enter your number!");
            var input = int.Parse(Console.ReadLine());

          for (int i = 1; i <= 12; i++)
            {
                int result = input * i;
                Console.WriteLine(result);
            }

          
        }

//Call the methods to test them in the Main method below
static void Main(string[] args)
        {
            FirstChallenge(); 

            SecondChallenge();

            ThirdChallenge();

            FourthChallenge();

            FifthChallenge();

            SixthChallenge();

            SeventhChallenge();

            EighthChallenge();
        }
}
}
