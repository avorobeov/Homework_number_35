using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_number_35
{
    class Program
    {
        static void Main(string[] args)
        {
            const string CommandSumCollection = "sum";
            const string CommandExit = "exit";

            List<int> numbers = new List<int>();
            bool isExit = false;
            string userInput;

            Console.WriteLine("Ведите любое число для его добавление в архив\n" +
                              $"для подсчёта всех элементов коллекции ведите команду {CommandSumCollection}\n" +
                              $"для выхода ведите команду {CommandExit}");

            while (isExit == false)
            {
                Console.Write("Ведите команду: ");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case CommandSumCollection:
                        PrintSumCollection(numbers);
                        break;

                    case CommandExit:
                        isExit = true;
                        break;

                    default:
                        AddNumber(numbers, userInput);
                        break;
                }
            }
        }

        private static void PrintSumCollection(List<int> numbers)
        {
            int sumCollection = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                sumCollection += numbers[i];
            }

            Console.WriteLine($"Сумма всех элементов коллекции: {sumCollection}");
        }

        private static void AddNumber(List<int> numbers, string userInput)
        {
            int number;

            if (int.TryParse(userInput, out number))
            {
                numbers.Add(number);
                Console.WriteLine($"Число {number} успешно добавлено");
            }
            else
            {
                Console.WriteLine("К сожалению ведённый вами символ не является цифрой");
            }

            return numbers;
        }
    }
}
