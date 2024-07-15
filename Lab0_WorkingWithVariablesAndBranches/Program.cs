using System;

namespace Lab0_WorkingWithVariablesAndBranches
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            int year = ReadYear();
            bool isLeapYear = IsLeapYear(year);
            WriteYear(year, isLeapYear);

            Console.WriteLine("\nЗадание 2");
            int temperature = 0;
            string scale = "";
            ReadTemperature(ref temperature, ref scale);
            double convertTemp = ConvertTemperature(temperature, ref scale);
            WriteTemperature(convertTemp, scale);

            Console.ReadKey();
        }

        // Задание 1

        static int ReadYear()
        {
            Console.WriteLine("Введите год: ");
            string input = Console.ReadLine();
            int year = int.Parse(input);
            return year;
        }

        static bool IsLeapYear(int year)
        {
            var isLeapYear = false;
            if (year % 4 == 0 && year % 100 != 0)
            {
                isLeapYear = true;
            }
            else if (year % 400 == 0)
            {
                isLeapYear = true;
            }
            return isLeapYear;
        }

        static void WriteYear(int year, bool isLeapYear)
        {
            Console.WriteLine($"{year} - {(isLeapYear ? "високосный" : "невисокосный")} год");
        }

        // Задание 2

        static void ReadTemperature(ref int temperature, ref string scale)
        {
            Console.WriteLine("Введите значение температуры: ");
            temperature = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Введите значение шкалы: ");
            scale = Console.ReadLine();
        }

        static double ConvertTemperature(int temperature, ref string scale)
        {
            var convertedTemp = 0.0;
            if (scale.ToUpper() == "C")
            {
                scale = "F";
                double temp = (temperature * 9) / 5 + 32;
                convertedTemp = Math.Round(temp);
            }else if (scale.ToUpper() == "F")
            {
                scale = "C";
                double temp = (temperature - 32) * 5 / 9;
                convertedTemp = Math.Round(temp);
            }
            return convertedTemp;
        }

        static void WriteTemperature(double temperature, string scale)
        {
            Console.WriteLine("Результат:" + temperature.ToString() + scale.ToString());
        }
    }
}
