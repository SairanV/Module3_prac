using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        // Задача 1 
        static void Expl01()
        {
            // Создаем одномерный массив A
            double[] A = new double[5];

            // Заполняем массив A числами, введенными с клавиатуры
            Console.WriteLine("Введите 5 чисел для массива A:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Введите число {i + 1}: ");
                A[i] = Convert.ToDouble(Console.ReadLine());
            }

            // Создаем двумерный массив B
            int[,] B = new int[3, 4];

            // Заполняем массив B случайными числами
            Random rand = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    B[i, j] = rand.Next(-10, 10);
                }
            }

            // Выводим массив A в одну строку
            Console.Write("Массив A: ");
            foreach (double element in A)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();

            // Выводим массив B в виде матрицы
            Console.WriteLine("Массив B:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(B[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // Находим общий максимальный элемент
            double maxA = A[0];
            double maxB = B[0, 0];
            foreach (double element in A)
            {
                if (element > maxA)
                {
                    maxA = element;
                }
            }
            foreach (double element in B)
            {
                if (element > maxB)
                {
                    maxB = element;
                }
            }
            double max = Math.Max(maxA, maxB);
            Console.WriteLine($"Общий максимальный элемент: {max}");

            // Находим общий минимальный элемент
            double minA = A[0];
            double minB = B[0, 0];
            foreach (double element in A)
            {
                if (element < minA)
                {
                    minA = element;
                }
            }
            foreach (double element in B)
            {
                if (element < minB)
                {
                    minB = element;
                }
            }
            double min = Math.Min(minA, minB);
            Console.WriteLine($"Общий минимальный элемент: {min}");

            // Находим общую сумму всех элементов
            double sumA = 0;
            double sumB = 0;
            foreach (double element in A)
            {
                sumA += element;
            }
            foreach (double element in B)
            {
                sumB += element;
            }
            double totalSum = sumA + sumB;
            Console.WriteLine($"Общая сумма всех элементов: {totalSum}");

            // Находим общее произведение всех элементов
            double productA = 1;
            double productB = 1;
            foreach (double element in A)
            {
                productA *= element;
            }
            foreach (double element in B)
            {
                productB *= element;
            }
            double totalProduct = productA * productB;
            Console.WriteLine($"Общее произведение всех элементов: {totalProduct}");

            // Находим сумму четных элементов массива A
            double evenSumA = 0;
            foreach (double element in A)
            {
                if (element % 2 == 0)
                {
                    evenSumA += element;
                }
            }
            Console.WriteLine($"Сумма четных элементов массива A: {evenSumA}");

            // Находим сумму нечетных столбцов массива B
            double oddColumnSum = 0;
            for (int j = 0; j < 4; j++)
            {
                if (j % 2 != 0)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        oddColumnSum += B[i, j];
                    }
                }
            }
            Console.WriteLine($"Сумма нечетных столбцов массива B: {oddColumnSum}");
        }

        // Задача 2
        static void Expl02()
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 6 };
            int[] arr2 = { 1, 2, 5, 6, 9, 10 };

            // Определяем максимальный размер третьего массива
            int maxLength = Math.Min(arr1.Length, arr2.Length);

            // Создаем третий массив 
            int[] commonElements = new int[maxLength];

            // Инициализируем счетчик для третьего массива
            int count = 0;

            // Проходим по элементам первого массива
            foreach (int item1 in arr1)
            {
                // Проверяем, содержится ли элемент во втором массиве
                if (Array.Exists(arr2, item2 => item2 == item1))
                {
                    // Если элемент содержится и в первом, и во втором массиве,
                    // добавляем его в третий массив, если еще не добавлен
                    if (Array.IndexOf(commonElements, item1) == -1)
                    {
                        commonElements[count] = item1;
                        count++;
                    }
                }
            }

            // Создаем и выводим результат (массив общих элементов)
            int[] resultArray = new int[count];
            Array.Copy(commonElements, resultArray, count);

            Console.WriteLine("Общие элементы без повторений:");
            foreach (int element in resultArray)
            {
                Console.WriteLine(element);
            }
        }

        // Задача 3
        static void Expl03()
        {
            Console.WriteLine("Введите строку:");
            string input = Console.ReadLine();
            string reversed = new string(input.Reverse().ToArray());
            bool isPalindrome = input.Equals(reversed, StringComparison.OrdinalIgnoreCase);
            Console.WriteLine(isPalindrome ? "Палиндром" : "Не палиндром");
        }

        // Задача 4
        static void Expl04()
        {
            Console.WriteLine("Введите предложение:");
            string input = Console.ReadLine();
            string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int wordCount = words.Length;
            Console.WriteLine($"Количество слов: {wordCount}");
        }

        // Задача 5
        static void Expl05()
        {
            int[,] matrix = new int[5, 5];
            Random random = new Random();

            // Заполнение массива случайными числами
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = random.Next(-100, 101);
                }
            }

            int min = matrix[0, 0];
            int max = matrix[0, 0];
            int sum = 0;

            // Находим минимальный и максимальный элементы и суммируем элементы между ними
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[i, j] < min)
                        min = matrix[i, j];
                    if (matrix[i, j] > max)
                        max = matrix[i, j];

                    if (matrix[i, j] > min && matrix[i, j] < max)
                        sum += matrix[i, j];
                }
            }

            Console.WriteLine("Минимальный элемент: " + min);
            Console.WriteLine("Максимальный элемент: " + max);
            Console.WriteLine("Сумма элементов между минимальным и максимальным: " + sum);
        }

        // Задача 6
        static void Expl06()
        {
            Console.WriteLine("Введите текст:");
            string input = Console.ReadLine();

            char currentChar = input[0];
            int currentCount = 1;
            int maxCount = 1;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == currentChar)
                {
                    currentCount++;
                }
                else
                {
                    currentChar = input[i];
                    currentCount = 1;
                }

                if (currentCount > maxCount)
                    maxCount = currentCount;
            }

            Console.WriteLine("Наибольшее количество идущих подряд одинаковых символов: " + maxCount);
        }

        // Задача 7
        static void Expl07()
        {
            Console.WriteLine("Введите строку:");
            string input = Console.ReadLine();
            var distinctLetters = input.Where(char.IsLetter).Select(char.ToLower).Distinct();
            int count = distinctLetters.Count();
            Console.WriteLine("Количество различных букв: " + count);
        }

        // Задача 8
        static void Expl08()
        {
            Console.WriteLine("Введите строку длиной 20 символов:");
            string input = Console.ReadLine();
            int digitCount = input.Count(char.IsDigit);
            Console.WriteLine("Количество цифр: " + digitCount);
        }

        // Задача 9
        static void Expl09()
        {
            Console.WriteLine("Введите текст из 20 символов:");
            string input = Console.ReadLine();
            string name = "Ваше имя"; // Замените на свое имя
            bool canSpellName = CanSpellWord(input, name);
            Console.WriteLine(canSpellName ? name : "Нет имени");
        }

        // Задача 10
        static void Expl10()
        {
            Console.WriteLine("Введите текст:");
            string input = Console.ReadLine();
            string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int count = words.Count(word => word.Length > 1 && word[0] == word[word.Length - 1]);
            Console.WriteLine("Количество слов с одинаковым первым и последним символом: " + count);
        }

        // Задача 11
        static void Expl11()
        {
            Console.WriteLine("Введите маленькую букву:");
            char inputChar = Console.ReadLine()[0];
            if (char.IsLower(inputChar) && char.IsLetter(inputChar))
            {
                char uppercaseChar = char.ToUpper(inputChar);
                Console.WriteLine("Соответствующая большая буква: " + uppercaseChar);
            }
            else
            {
                Console.WriteLine("Это не маленькая буква русского алфавита.");
            }
        }

        // Вспомогательный метод для проверки
        static bool CanSpellWord(string input, string word)
        {
            int[] inputLetterCount = new int[26];
            foreach (char letter in input)
            {
                if (char.IsLetter(letter))
                {
                    int index = char.ToLower(letter) - 'а'; // Преобразуем букву в индекс от 0 до 25
                    inputLetterCount[index]++;
                }
            }

            int[] wordLetterCount = new int[26];
            foreach (char letter in word)
            {
                int index = char.ToLower(letter) - 'а';
                wordLetterCount[index]++;
            }

            for (int i = 0; i < 26; i++)
            {
                if (inputLetterCount[i] < wordLetterCount[i])
                    return false;
            }

            return true;
        }




        static void Main(string[] args)
        {
            Console.WriteLine("Выберите задачу (1-11):");
            int taskNumber = int.Parse(Console.ReadLine());
            { }
            switch (taskNumber)
            {
                case 1:
                    Expl01();
                    break;
                case 2:
                    Expl02();
                    break;
                case 3:
                    Expl03();
                    break;
                case 4:
                    Expl04();
                    break;
                case 5:
                    Expl05();
                    break;
                case 6:
                    Expl06();
                    break;
                case 7:
                    Expl06();
                    break;
                case 8:
                    Expl07();
                    break;
                case 9:
                    Expl08();
                    break;
                case 10:
                    Expl09();
                    break;
                case 11:
                    Expl11();
                    break;
                default:
                    Console.WriteLine("Неверный номер задачи.");
                    break;
            }
        }
        }

    }

