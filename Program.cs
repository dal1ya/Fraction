using System;

namespace dfy
{
    class Fraction
    {
        public int intPart;
        public int fractionPart;

        public Fraction(double a)
        {
            double qwe;
            string support;
            intPart = Convert.ToInt32((Math.Floor(a)));
            string supp = Convert.ToString(a);
            int len = supp.Length;
            qwe = Math.Round(a - Convert.ToInt32(Math.Floor(a)), len-2);
            int start = 0;
            support = Convert.ToString(qwe);
            for (int i = 2; i < (support.Length); i++)
            {
                if (support[i] != '0')
                {
                    start = i;
                    break;
                }
            }


            string newsupport = support.Remove(0, start);

            fractionPart = Convert.ToInt32(newsupport);
        }

        public static double Sum (double a, double b)
        {
            return (a+b);
        }

        public static double Sub(double a, double b)
        {
            return (a - b);
        }
        
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            double a = 16.048653504;
            Fraction fr;
            fr = new Fraction(a);
            
            double sum;
            double sub;
            
            Console.WriteLine("Заданное число: " + a);
            Console.WriteLine("Целая часть: " + fr.intPart);
            Console.WriteLine("Дробная часть: " + fr.fractionPart);

            sum = Fraction.Sum(fr.intPart, fr.fractionPart);
            sub = Fraction.Sub(fr.intPart, fr.fractionPart);
            
            Console.WriteLine("Сумма: " + sum);
            Console.WriteLine("Разность: " + sub);
        }
    }
}