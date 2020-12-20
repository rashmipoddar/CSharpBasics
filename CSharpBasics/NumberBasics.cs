using System;
namespace CSharpBasics
{
    public class NumberBasics
    {
        public NumberBasics()
        {
        }

        public static void runNumberBasics()
        {
            double number = 10.5675;
            double a = 5.678;
            double b = 8.456;
            int x = 10;
            int y = 5;


            // Explicit type conversion

            // Store integer in double 
            a = x;
            Console.WriteLine(a); // 10

            // Store double in integer
            y = (int) b;
            Console.WriteLine(y); // 8

            bool c = true;
            int d = 10;
            double e = 10.76;
            char f = 'f';

            string p = c.ToString();
            string q = d.ToString();
            string r = e.ToString();
            string s = f.ToString();

            Console.WriteLine($"p is type {p.GetType()} and value {p}"); // p is type System.String and value True
            Console.WriteLine($"q is type {q.GetType()} and value {q}"); // q is type System.String and value 10
            Console.WriteLine($"r is type {r.GetType()} and value {r}"); // r is type System.String and value 10.76
            Console.WriteLine($"s is type {s.GetType()} and value {s}"); // s is type System.String and value f

            bool t = bool.Parse(p);
            int u = int.Parse(q);
            double v = double.Parse(r);
            char w = char.Parse(s);

            Console.WriteLine($"t is type {t.GetType()} and value {t}"); // t is type System.Boolean and value True
            Console.WriteLine($"u is type {u.GetType()} and value {u}"); // u is type System.Int32 and value 10
            Console.WriteLine($"v is type {v.GetType()} and value {v}"); // v is type System.Double and value 10.76
            Console.WriteLine($"w is type {w.GetType()} and value {w}"); // w is type System.Char and value f


            reduceDecimalPlaces(number); // 10.57
        }

        // Given a number with more than more than two places print number with 2 decimal places
        static void reduceDecimalPlaces(double number)
        {
            // Console.WriteLine(Math.Round(number, 2));
            Console.WriteLine(String.Format("{0:0.00}", number));

        }

    }
}
