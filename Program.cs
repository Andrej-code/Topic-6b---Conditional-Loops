namespace Topic_6b___Conditional_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // #1 - Counting  with Conditional Loops

            //int i = 10;
            //while (i >= 1)
            //{
            //    Console.WriteLine(i);
            //    i -= 2;
            //}
            //Console.WriteLine();

            // #2 - Vaild Number

            //int number;
            //double number1;
            //Console.WriteLine("Please enter an integer: ");
            //while (!Int32.TryParse(Console.ReadLine(), out number))
            //while(!Double.TryParse(Console.ReadLine(), out number1))
            //{
            //    Console.WriteLine("Invalid integer, try again.");
            //}
            //Console.WriteLine("Thanks for " + number + "!");

            // #3 - End at Any unknown Time
            //Random generator = new Random();
            //int guesses = 0, guess, secrectNum;
            //secrectNum = generator.Next(1, 11);

            //bool done = false;
            //while (!done)
            //{
            //    Console.WriteLine("Guess a number from 1-10, or -1 to quit.");
            //    while (!Int32.TryParse(Console.ReadLine(), out guess))
            //    {
            //        Console.WriteLine("Invalid integer, try again.");
            //        guesses++;
            //    }

            //    guesses++;
            //    if(guess == secrectNum)
            //    {
            //        done = true;
            //        Console.WriteLine("You Win");
            //    }
            //    else if ( guess == -1)
            //    {
            //           done = true;
            //        Console.WriteLine("User quits, thanks for playing!");
            //    }
            //    else if (guess >= 11)
            //    {
            //        done = true;
            //        Console.WriteLine("Out of guesses, you lose. Thanks for playing");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Incorrect, guess again");
            //    }
            //}

            // #4 - Verifying Input Ranges

            double bet, wallet = 100;
            Console.WriteLine("How much money do you want to bet? You have $" + wallet);
            bet = Convert.ToInt32(Console.ReadLine());
            while (bet > wallet || bet > 0)
            {
                Console.WriteLine("That is more than you have, please enter a vlaid amount: ");
                bet = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Thanks for betting a reasonable amount");
        }
    }
}
