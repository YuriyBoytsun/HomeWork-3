using System;

namespace HW3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"
а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.Продемонстрировать работу структуры.
б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
в) Добавить диалог с использованием switch демонстрирующий работу класса.


");
           

            Console.WriteLine("Введите вещественную часть первого комплексного числа");
            int a1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите мнимую часть первого комплексного числа");
            int b1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите вещественную часть первого комплексного числа");
            int a2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите мнимую часть первого комплексного числа");
            int b2 = Convert.ToInt32(Console.ReadLine());

            Complex num1 = new Complex(a1,b1);
            Complex num2 = new Complex(a2,b2);
            Complex num3;

            Console.WriteLine(num1.Print());
            Console.WriteLine(num2.Print());

            
            Console.WriteLine("Сумма чисел нажмите 1.\nВычитание чисел нажмите 2.\nУмножение чисел нажмите 3");
            int i = Convert.ToInt32(Console.ReadLine());
            string s="";
            switch (i)
            {
                case 1: num3 = num1.Sum(num2); s = $"РЕЗУЛЬТАТ СУММЫ:\n {num3.Print()}";
                    break;
                case 2: num3 = num1.Sub(num2); s = $"РЕЗУЛЬТАТ ВЫЧИТАНИЯ:\n {num3.Print()}";
                    break;
                case 3: num3 = num1.Mul(num2); s = $"РЕЗУЛЬТАТ УМНОЖЕНИЯ:\n {num3.Print()}";
                    break;
            }
            Console.WriteLine(s);

            

            Console.ReadLine();
        }
    }
}
