using USQLCSharpProject1_for_practical_work_2;

namespace PracticalWork
{
    class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber n1 = new ComplexNumber(1.34, 2.77);
            ComplexNumber n2 = new ComplexNumber(-3.94, 9.01);

            Console.WriteLine($"{n1} + {n2} = {n1 + n2}");
            Console.WriteLine($"{n1} - {n2} = {n1 - n2}");
            Console.WriteLine($"{n1} * {n2} = {n1 * n2}");

            double real = -33.31;

            Console.WriteLine($"{n1} + {real} = {n1 + real}");
            Console.WriteLine($"{n1} - {real} = {n1 - real}");
            Console.WriteLine($"{n1} * {real} = {n1 * real}");

            if (n1 == n2) Console.WriteLine($"{n1} is equal {n2}");
            else Console.WriteLine($"{n1} isn't equal {n2}");

            ComplexNumber n3 = new ComplexNumber(1.34, 2.77);

            if (n1 == n3) Console.WriteLine($"{n1} is equal {n3}");
            else Console.WriteLine($"{n1} isn't equal {n3}");

            Console.WriteLine($"{n1} > {n2}? {n1 > n2}");
            Console.WriteLine($"{n1} >= {n3}? {n1 >= n3}");
            Console.WriteLine($"{n1} < {n2}? {n1 < n2}");
            Console.WriteLine($"{n1} <= {n3}? {n1 <= n3}");

            if (n1) Console.WriteLine($"{n1} is true");
            else Console.WriteLine($"{n1} is false");

            ComplexNumber n4 = new ComplexNumber(0, 0);

            if (n4) Console.WriteLine($"{n4} is true");
            else Console.WriteLine($"{n4} is false");

            int realpart = n2;
            double realpart2 = (double)n2;

            Console.WriteLine($"implicit int {n2} is {realpart}, explicit double {n2} is {realpart2}");
        }
    }
}