using System;

namespace Func
{
    public class Class1
    {
       public static void SumMult(double[] arr)
        {
            double sum = 0;
            double mul = 1;
            foreach (double n in arr)
            {
                sum += n;
                mul *= n;
            }
            Console.WriteLine("Сумма чисел равна {0}\nПроизведение чисел равно {1}", sum, mul);

        }
    }
}
