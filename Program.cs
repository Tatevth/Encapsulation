using System;


namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(46);
            int r = circle.R;
            circle.R = 25;
            r = circle.R;
            circle.R = 105;
            r = circle.R;
            Console.WriteLine(circle.R);
            Console.ReadKey();
        }
    }
}
