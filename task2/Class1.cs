using System;


namespace HW3._2
{
    class Nums

    {
        public int inputNum { get; set; }
        public int MyNums()
        {
            
            string someNum = "";
            int result = 0;
            while (inputNum != 0)
            {
                Console.WriteLine("Введите число. Чтобы завершить введите 0.");
                inputNum = int.Parse(Console.ReadLine());


                if (inputNum % 2 != 0 && inputNum > 0) result += inputNum;
                
            }
            return result;
        }

    }
}
