using System;

namespace ConsoleApp9
{
    class Program
    {
        public static int UserQuess()
        {
            const int MAX = 10;
            const int ZERO = 0;
            bool isTrue = true;
            int answer = 0;

            while (isTrue)
            {
                Console.WriteLine("Please enter in a postive digit number between one and ten (1 - 10)!");
                var ans = Console.ReadLine();

                if (!int.TryParse(ans, out answer))
                {
                    Console.WriteLine("You did not enter in a digit number \n");
                }
                else if (answer < ZERO || answer > MAX)
                {
                    Console.WriteLine("Please try again. You did not enter in a positive number \n");
                }
                else
                {

                    isTrue = false;
                }
            }

            return answer;
        }
        public static void GuessingGame(int pGuess)
        {
            const int ZERO = 0;
            int answer = 0;
            int theGuess;
            bool isTrue = true;
            int chances = 3;


            Random rn = new Random();
            theGuess = rn.Next(0, 10);

            while (isTrue)
            {
                if (chances == ZERO)
                {
                    Console.WriteLine("You ran out of chances.");
                    Console.WriteLine("You have lost \n");
                    break;
                }

                if (theGuess == answer)
                {
                    Console.WriteLine("Congratulation you won! \n");
                    break;

                    //OR:

                    //IsTrue = false;
                }
                else if (answer < theGuess)
                {
                    Console.WriteLine("You did not guess correctly. Guess higher");
                    Console.WriteLine("Chances remaining: " + chances);
                    chances--;
                    answer = UserQuess();

                }
                else if (answer > theGuess)
                {
                    Console.WriteLine("You did not guess correctly. Guess lower \n");
                    Console.WriteLine("Chances remaining: " + chances);
                    chances--;
                    answer = UserQuess();
                }

            }

        }
        public static void PlayAgain()
        {

            const string YES = "yes";
            const string NO = "no";
            int answer;
            bool isTrue = true;
            string userInput;


            while (isTrue)
            {

                answer = UserQuess();
                GuessingGame(answer);

                while (isTrue)
                {
                    Console.WriteLine("Would you like to play again?");
                    Console.WriteLine("Enter Yes to play again");
                    Console.WriteLine("OR: enter no to exit the guessing game");
                    userInput = Console.ReadLine();

                    if (String.IsNullOrEmpty(userInput))
                    {
                        Console.WriteLine("You did not enter anything in! Please try again \n. ");
                    }
                    else if (userInput.ToLower() == YES)
                    {
                        isTrue = true;
                        break;
                    }
                    else if (userInput.ToLower() == NO)
                    {
                        isTrue = false;
                        break;
                    }
                }

            }

        }
        static void Main(string[] args)
        {

            PlayAgain();
            Console.WriteLine("Thanks for playing! \n");

        }
    }
}
