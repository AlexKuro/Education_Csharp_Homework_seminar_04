namespace Homework;
class Program
{
    static void Main(string[] args)
    {
        //Домашнее задание семинара №4

        void Task_25()
        {
            /*Задача 25: Используя определение степени числа, напишите цикл, 
            который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
              3, 5 -> 243 (3⁵)
            2, 4 -> 16 */
            Console.WriteLine("                        ------Задача 25-------");
            Console.WriteLine("Используя определение степени числа, напишите цикл, который принимает");
            Console.WriteLine("на вход два натуральных числа (A и B) и возводит число A в степень B.");
            Console.WriteLine();
            Random rand = new Random();
            int numberA = rand.Next(1, 9);
            int numberB = rand.Next(1, 9);
            Console.WriteLine($"Введено два натуральных числа: ({numberA}, {numberB})");
            int length = numberB;
            int sum = 1;
            for (int i = 0; i < length; i++)
            {
                sum = sum * numberA;
            }
            Console.WriteLine($"   {numberA}, {numberB} -> {sum} ({numberA}^{numberB})");
            Console.WriteLine("    Ответ: " + sum);
            Console.WriteLine();
        }

        void Task_27_1() //Первый вариант решения задачи № 27
        {
            /*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
               452 -> 11
                82 -> 10
              9012 -> 12*/

            Console.WriteLine("                        ------Задача 27------- I способ");
            Console.WriteLine("Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");
            Console.WriteLine();
            Console.Write("Введите число:-> ");

            int container = Convert.ToInt32(Console.ReadLine());
            int number = Math.Abs(container);
            int size = DigitsNumber(number);
            int[] arrayNumber = new int[size + 1];
            int count = size - 1;

            while (number > 0)
            {
                arrayNumber[count] = number % 10;
                number /= 10;
                count = count - 1;
            }

            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                sum = sum + arrayNumber[i];
            }
            Console.WriteLine($"Cуммa цифр в числе {container} -> {sum}");
            Console.WriteLine();
        }

        void Task_27_2() //Второй вариант решения задачи № 27
        {
            /*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
               452 -> 11
                82 -> 10
              9012 -> 12*/

            Console.WriteLine("                        ------Задача 27------- II способ");
            Console.WriteLine("Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");
            Console.WriteLine();
            Console.Write("Введите число:-> ");

            int container = Convert.ToInt32(Console.ReadLine());
            int number = Math.Abs(container);
            int sum = 0;
            while (number > 0)
            {
                sum = sum + number % 10;
                number /= 10;
            }

            Console.WriteLine($"Cуммa цифр в числе {container} -> {sum}");
            Console.WriteLine();
        }

        void Task_29()
        {
            /* Задача 29: Напишите программу, которая задаёт массив из 8 
            случайных целых чисел и выводит отсортированный по модулю массив.
                -2, 1, -7, 5, 19 -> [1, -2, 5, -7, 19]
                6, 1, -33 -> [1, 6, -33] */
            Console.WriteLine("                        ------Задача 29-------");
            Console.WriteLine("          Напишите программу, которая задаёт массив из 8");
            Console.WriteLine("случайных целых чисел и выводит отсортированный по модулю массив.");
            Console.WriteLine();

            int[] numberArray = new int[8];
            FillArray(numberArray);
            Console.Write("       ");
            PrintArray(numberArray);
            SelectionSort(numberArray);
            Console.Write("   --->  [");
            PrintArray(numberArray);
            Console.Write(" ]");
            Console.WriteLine();
        }

        int DigitsNumber(int number)
        {
            int count = 0;
            while (number > 0)
            {
                number /= 10;
                count = count + 1;
            }
            return count;
        }

        void FillArray(int[] array) //метод заполнения массива случайными числами
        {
            int length = array.Length;
            for (int i = 0; i < length; i++)
            {
                array[i] = new Random().Next(-10, 10);
            }
        }

        void PrintArray(int[] pArray) // печать массива
        {
            int length = pArray.Length;
            for (int i = 0; i < length; i++)
            {
                Console.Write($" {pArray[i]}");
            }
        }

        void SelectionSort(int[] sortArray) //сортировка массива по модулю
        {
            for (int i = 0; i < sortArray.Length - 1; i++)
            {
                int minPosition = i;
                for (int j = i + 1; j < sortArray.Length; j++)
                {
                    if (Math.Abs(sortArray[j]) < Math.Abs(sortArray[minPosition])) minPosition = j;
                }
                int temporary = sortArray[i];
                sortArray[i] = sortArray[minPosition];
                sortArray[minPosition] = temporary;
            }
        }

        Task_25();
        Task_27_1(); //Первый вариант решения задачи № 27
        Task_27_2(); //Второй вариант решения задачи № 27
        Task_29();
    }
}
