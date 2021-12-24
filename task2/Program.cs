using System;

namespace HW3._2
{
    
    class Program
    {
        
      
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число. Чтобы завершить введите 0.");
            Nums input = new Nums();
            input.inputNum = int.Parse(Console.ReadLine());
            Console.Write($"Сумма всех нечётных чисел введённых вами состовляет {Nums.MyNums()}");
            Console.ReadLine();
        }
    }
}
