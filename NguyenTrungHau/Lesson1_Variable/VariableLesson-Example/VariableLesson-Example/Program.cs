using System;

namespace VariableLesson_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a = 10;
            decimal b;
            decimal c = a + b;
            Console.WriteLine("a before = {0}",a);

            
            b = ++a;
            Console.WriteLine("a after = {0}, b = {1}", a, b);
            Console.ReadLine();
        }
    }
}
