namespace Hangman
{
    public class GameLogic   // Contains game logic
    {
        public static void Run()
        {


            string hiddenword = "lmao";

            int amountOfTry = 10;
            string guess = "";
            while (amountOfTry > 0 && guess != hiddenword)
            {
                Console.WriteLine("==Guess the word!==");
                guess = Console.ReadLine() ?? string.Empty;
               
                amountOfTry--;

                if (guess.Length >= 1 && guess == hiddenword)
                {
                    Console.WriteLine("That char is correct");
                    Console.WriteLine(guess);
                }
                else if (guess.Length==1 && hiddenword.Contains(guess))
                {
                    Console.WriteLine($"That letter is in gthe word: {guess}");
                    
                }
                else { Console.WriteLine("Wrong awnser"); }

                
            }
            if (guess == hiddenword && amountOfTry >= 1)
            {
                Console.WriteLine($"YAAAAY, you made it with {amountOfTry} guesses left!!");
            }
            else if (guess == hiddenword && amountOfTry == 0)
            {
                Console.WriteLine("YAAAY, you made it just in time!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sadly you were unable to save the hangman :C");
                Console.ResetColor();
            }
        }
        public static void WrongInput()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Wrong Input");
            Console.ResetColor();
        }
    }
}
