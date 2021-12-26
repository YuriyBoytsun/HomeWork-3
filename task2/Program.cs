using System;

namespace HW3._2
{
    
    class Program
    {
       
       static public void MyForm()
        {
            int num;
            int result=0;
            string nums= "Складываемые числа:";
            do
            {
                Console.WriteLine("Введите число. Для выхода введите 0");
                 int.TryParse(Console.ReadLine(),out num);
                if (num % 2 == 0 && num!=0) { result += num; nums = nums + " " + num; }
            }
            while (num != 0);
            Console.WriteLine($"{nums}. Результат: {result}");
        }
      
        static void Main(string[] args)
        {
            Console.WriteLine(@"
С клавиатуры вводятся числа, пока не будет введён 0 
(каждое число в новой строке). Требуется подсчитать сумму всех нечётных положительных чисел.
Сами числа и сумму вывести на экран, используя tryParse.

");
            MyForm();
            Console.ReadKey();

            
        }
    }
}
