using System;

namespace CharacterSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            for (int simbol = 0; simbol < input.Length; simbol++)
            {
                char letter = input[simbol];
                Console.WriteLine(letter);
            }
        }
    }
}
