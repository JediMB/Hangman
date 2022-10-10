using System.IO.Enumeration;

namespace Hangman
{
    public static class StringImport
    {
        private const string fileName = "ImportStrings.txt";
        private static readonly Random random = new();
        private static string[] strings = ReadFile();

        private static string[] ReadFile()
        {
            string[] importStrings;

            if (File.Exists(fileName))
            {
                importStrings = File.ReadAllLines(fileName);

                if (importStrings.Length > 1)
                {
                    Console.WriteLine($"Game dictionary imported from {fileName}.");
                    return importStrings;
                }
            }

            importStrings = new string[] { "archipelago", "banding", "coloration", "daybreak", "entropy", "fulfillment", "graveyard",
                    "hastening", "incredulous", "jawbreaker", "karate", "landfall", "madness", "naturalize", "opponent", "pawn",
                    "quest", "radical", "supreme", "transition", "underhanded", "victorious", "xenobiotic", "yam", "zirconium" };

            File.WriteAllLines(fileName, importStrings);

            Console.WriteLine($"No game dictionary found. Populating {fileName} with default list of words.");
            return importStrings;

        }

        public static string GetRandomString()
        {
            return strings[random.Next(strings.Length)];
        }
    }
}
