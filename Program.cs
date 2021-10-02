using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите трехзначное число: ");
            double a = double.Parse(Console.ReadLine());
            if (a / 100 == a % 100)
                Console.Write($"Число {a} - палиндром");
            else
                Console.WriteLine($"Число {a} - не палиндром");



            Console.WriteLine("Задание 2");
            Console.WriteLine("Введите сторону a в см: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону b в см: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите диаметр головы Вани - (d) в см: ");
            int d = Convert.ToInt32(Console.ReadLine());
            if (a >= d + 1 && b >= d + 1)
                Console.WriteLine("Ваня сможет просунуть голову");
            else
                Console.WriteLine("Ваня не сможет просунуть голову");



            Console.WriteLine("Задание 3");
            Console.WriteLine("Введите день недели: ");
            int day = Convert.ToInt32(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Сегодня " + (DayOfWeek)day);
                    break;
                case 2:
                    Console.WriteLine("Сегодня " + (DayOfWeek)day);
                    break;
                case 3:
                    Console.WriteLine("Сегодня " + (DayOfWeek)day);
                    break;
                case 4:
                    Console.WriteLine("Сегодня " + (DayOfWeek)day);
                    break;
                case 5:
                    Console.WriteLine("Сегодня " + (DayOfWeek)day);
                    break;
                case 6:
                    Console.WriteLine("Сегодня " + (DayOfWeek)day);
                    break;
                case 7:
                    Console.WriteLine("Сегодня " + (DayOfWeek)day);
                    break;
            }



            Console.WriteLine("Задание 4");
            Console.WriteLine("Введите k, чтобы узнать какая карта скрыта под этим номером: ");
            {
                int k = Convert.ToInt32(Console.ReadLine());
                while (k < 6 || k > 14)
                {
                        Console.WriteLine("k принимает значения от 6 до 14");
                }
                switch (k)
                {
                    case 6:
                        Console.WriteLine("Шесть");
                        break;
                    case 7:
                        Console.WriteLine("Семь");
                        break;
                    case 8:
                        Console.WriteLine("Восемь");
                        break;
                    case 9:
                        Console.WriteLine("Девять");
                        break;
                    case 10:
                        Console.WriteLine("Десять");
                        break;
                    case 11:
                        Console.WriteLine("Валет");
                        break;
                    case 12:
                        Console.WriteLine("Дама");
                        break;
                    case 13:
                        Console.WriteLine("Король");
                        break;
                    case 14:
                        Console.WriteLine("Туз");
                        break;
                }
            }



            Console.WriteLine("Задание 5");
            int r = 6370;
            for (int i = 1; i < 11; i++)
            { 
                Console.WriteLine(string.Format($"Высота  = {i}") + " Расстояние  = " + Math.Sqrt((r + i) * (r + i) - r * r));
            }
            


            Console.WriteLine("Задание 6");
            Console.WriteLine("Введите число (n), чтобы составить для него таблицу умножения: ");
            byte n = Convert.ToByte(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(string.Format($"{i} * {n} = ") + i * n);
            }
            
            
            
            Console.WriteLine("Задание 7");
            int sum = 0; n = 0;
            int num = 0;
            Console.WriteLine("Введите целое число: ");
            if (num >= 0)
            {
                num = Convert.ToInt32(Console.ReadLine());
                sum += num;
                n++;
            }
            Console.WriteLine("Среднее арифметическое = " + sum / n);
            Console.ReadKey();
            


            Console.WriteLine("Задание 8");
            int[] numbers = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Введите число под " + (i + 1) + " номером: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            bool answer = false;
            for (int i = 0; i < 9; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    sum = i;
                    answer = true;
                    break;
                }
            }
            if (answer)
            {
                Console.WriteLine($"Последовательность не возрастает, так как число {sum} прерывает ее");
            }
            else
            {
                Console.WriteLine("Последовательность возрастает");
            }
            
            
            
            Console.WriteLine("Задание 9");
            sum = 0;
            int w = 0;
            Console.WriteLine("Введите целое число: ");
            num = Convert.ToInt32(Console.ReadLine());
            while (num != 0)
            {
                w++;
                if (w % 3 != 0)
                continue;
                sum += num;
            }
            Console.WriteLine($"Сумма = {sum}");



            Console.WriteLine("Задание 10");
            sum = 0; num = 0;
            Console.WriteLine("Введите целое число: ");
            Amount:
            num = Convert.ToInt32(Console.ReadLine());
            if (num != 0)
            {
                sum += num;
                goto Amount;
            }
            Console.WriteLine($"Сумма = {num}");
            Console.ReadKey();
            }
        }
    }

