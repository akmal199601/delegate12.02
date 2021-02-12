using System;

namespace delegate1
{
    class Program
    {
        delegate double minus(double a, double b);
        delegate double plus(double a, double b);
        delegate double devide(double a, double b);
        delegate double multiply(double a, double b);

        static void Main(string[] args)
        {
            minus min = Minus;
            plus pl = Plus;
            devide deve = Devide;
            multiply mult = Multiply;
            char fun = ' ';
            Console.WriteLine("Enter x:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter function of methods:");
            fun = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter y:");
            double y = Convert.ToDouble(Console.ReadLine());
            double res = 0;
            if (y != 0)
            {
                switch (fun)
                {
                    case '+':
                        res = pl.Invoke(x, y);
                        break;
                    case '-':
                        res = min.Invoke(x, y);
                        break;
                    case '/':
                        res = deve.Invoke(x, y);
                        break;
                    case '*':
                        res = mult.Invoke(x, y);
                        break;
                }
                Console.WriteLine(res);
            }
            else
            {
                Console.WriteLine("I cannot devide to 0");
            }
        }

        //static double Minus(double a, double b)
        //{
        //    return a - b;
        //}
        //static double Plus(double a, double b)
        //{
        //    return a + b;
        //}
        //static double Devide(double a, double b)
        //{
        //    return a / b;
        //}
        //static double Multiply(double a, double b)
        //{
        //    return a * b;
        //}
    }
}
