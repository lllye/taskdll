using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Func;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество чисел");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] nums = new double[n];
            Console.WriteLine("Введите значения чисел");
            for (int i = 0; i<n;i++ )
            {
              nums[i] = Convert.ToDouble(Console.ReadLine());
            }
            Class1.SumMult(nums);
            Console.ReadKey();
        }
    }
}
