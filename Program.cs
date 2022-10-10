namespace Hangman
{
    internal class Program
    {
        static void Main(/*string[] args*/)
        {
            int amountOfTry = 10;
            bool gameOver = false;
            // string randword = StringImport.SomeMethod()

            while (!gameOver)
            {
                GameLogic.Run();
               
                


                // GameLogic.SomeMethod()

                // Hangman.Draw?()

                // GameLogic.Draw?()

                gameOver = true; // tmp
            }

            Console.ReadKey();
        }
    }
}