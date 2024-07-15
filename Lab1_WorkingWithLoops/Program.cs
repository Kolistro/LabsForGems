using System;
using System.Collections.Generic;


namespace Lab1_WorkingWithLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine("Вводите слова, завершая каждое нажатием Enter.");
            Console.WriteLine("Для выхода наберите \"exit\".\n");
            List<string> words = ReadWords();
            string longestWord = FindLongestWord(words, out int maxLenghtWord);
            Console.WriteLine("\nСчитывание завершено.");
            Console.WriteLine($"Самое длинное слово: \"{longestWord.ToUpper()}\" ({maxLenghtWord})");
            
            Console.WriteLine("\nЗадание 2");
            PlayHeadsOrTails();

            Console.ReadKey();
        }


        // Задание 1
        static List<string> ReadWords()
        {
            List<string> words = new List<string>();
            var word = "";
            while ((word = Console.ReadLine()) != "exit")
            {    
                words.Add(word);
            }
            return words;
        }

        static string FindLongestWord(List<string> words, out int maxLenghtWord)
        {
            maxLenghtWord = 0;
            string longestWord = "";
            foreach (string word in words)
            {
                if (word.Length > maxLenghtWord)
                {
                    maxLenghtWord = word.Length;
                    longestWord = word;
                }
            }
            return longestWord;
        }

        // Задание 2
        static void PlayHeadsOrTails()
        {
            Console.WriteLine("Игра началась!");
            Random random = new Random();
            var numberOfAttempts = 0;
            var numberOfVictories = 0;
            int number = 0;
            while (true) 
            {
                Console.WriteLine("Введите число: ");
                var input = Console.ReadLine();
                number = int.Parse(input);

                if(number != 0 && number != 1)
                {
                    break;
                }
                else if (number == random.Next(2))
                {
                    Console.WriteLine("Угадали!");
                    numberOfVictories++;
                }
                else
                {
                    Console.WriteLine("Попробуйте снова");
                }
                numberOfAttempts++;
            } 
            Console.WriteLine($"Игра окончена со счётом {numberOfVictories}, " +
            $"угадано {CalculateWinningPercentage(numberOfVictories, numberOfAttempts)}% бросков.");
        }

        static double CalculateWinningPercentage(int numberOfVictories, int numberOfAttempts)
        {
            var result = 0.0;
            if (numberOfVictories != 0)
            {
                var temp = (double)numberOfVictories / numberOfAttempts * 100;
                result = Math.Round(temp);
            }
            return result;
        }
    }
}
