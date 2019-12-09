using System;

namespace VectorMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector3 one = new Vector3(5, 4, 3);
            Vector3 two = new Vector3(2, 8, 6);

            Console.WriteLine("Adding two vectors: ");
            Console.WriteLine($"With a static method {Vector3.Add(one, two)}");
            one.Add(two);
            Console.WriteLine($"With a class method {one}");

            Console.WriteLine($"Vector Scaling: {10 * one}");

            Console.WriteLine($"Vector comparison: {one == two}");
         
            Console.WriteLine($"Vector comparison: {new Vector3(2, 8, 6) == two}");
        }

    }
}
