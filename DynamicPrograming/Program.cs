using System;
using System.Threading.Tasks;

namespace DynamicPrograming
{
    class Program
    {
        static void Main(string[] args)
        {
            //await Task.Run(() => );
            Console.WriteLine($"{NthFibonacci.NthFibDyn(50)}");
            //Console.WriteLine($"Memoized => {NthFibonacci.NthFibMemo(45)}");
        }
    }
}