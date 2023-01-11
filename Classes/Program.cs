using System;

namespace Classes
{

    partial class Program
    { 
        static void Main(string[] args)

        {
            useParams();
        }

        static void useParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2, 3, 4, 5));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5 }));
        }

        static void usePoint()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(new Point(40, 60));
                Console.WriteLine("Point is at {0}, {1}", point.X, point.Y);


                point.Move(100, 200);
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }
    }
}
