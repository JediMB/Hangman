namespace Hangman
{
    internal class Program
    {
        static void Main(/*string[] args*/)
        {
            bool gameOver = false;
            string randomWord = StringImport.GetRandomString();

            while (!gameOver)
            {
                // GameLogic.SomeMethod()

                // Hangman.Draw?()

                // GameLogic.Draw?()

                gameOver = true; // tmp
            }

            Console.ReadKey();
        }
    }
}