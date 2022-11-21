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
            Console.WriteLine("                     ------Задача 25-------");
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

        }

        void Task_27_1() //Первый вариант решения задачи № 27
        {
            /*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
               452 -> 11
                82 -> 10
              9012 -> 12*/

            Console.WriteLine("                        ------Задача 27-------");
            Console.WriteLine("Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");
            Console.WriteLine();
            Console.Write("Введите число:-> ");

            int container = Convert.ToInt32(Console.ReadLine());
            int number = Math.Abs(container);
            int size = DigitsNumber(number);
            int[] arrayNumber = new int[size + 1];
            int count = size - 1;
            int sum_1 = 0;
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

        }

        void Task_27_2() //Второй вариант решения задачи № 27
        {
            /*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
               452 -> 11
                82 -> 10
              9012 -> 12*/

            Console.WriteLine("                        ------Задача 27-------");
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

        //Task_25();
        //Task_27_1(); //Первый вариант решения задачи № 27
        Task_27_2(); //Второй вариант решения задачи № 27       
    }
}
