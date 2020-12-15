using System;
using System.Linq;

namespace lr2_severalCriteria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество уровней критериев иерархии: ");
            string countCriteria_str = Console.ReadLine();

            double countCriteria = GetNumber(countCriteria_str);

            Calculate(countCriteria);

            Console.ReadKey();
        }

        static void Calculate(double countCriteria)
        {
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            double[][] criteria = new double[(int)countCriteria][];
            for (int i = 0; i < countCriteria; i++)
            {
                Console.Write($"Введите количество критериев {i+1}й иерархии: ");
                string str = Console.ReadLine();
                int count = (int)GetNumber(str);
                criteria[i] = new double[count];
                string test = Console.ReadLine();
                string[] temp = test.Split(new Char[] { ' ' });
                for (int j = 0; j < count; j++)
                {
                    criteria[i][j] = double.Parse(temp[j]);
                }
            }

            double count_answ = criteria[criteria.Length-1].Length / criteria[criteria.Length - 2].Length;

            double[] ans = new double[(int)count_answ];

            for (int i = 0; i < count_answ; i++)
            {
                double res_ = 1;

                for (int j = 0; j < criteria[criteria.Length - 2].Length; j=j+ (int)count_answ)
                {
                    for (int q = 0; q < criteria[criteria.Length - 3].Length; q++)
                    {
                        res_ = ans[i] * criteria[j][q];
                    }
                }
                ans[i] = res_;
            }
            double[] ansDop = ans;
            Array.Sort(ansDop);
            int ind = Array.IndexOf(ans, ansDop[0]);
            Console.WriteLine($"{alpha[ind]}");
        }

        static double GetNumber(string str)
        {
            double number;
            bool success = Double.TryParse(str, out number);

            if (success)
            {
                return number;
            }
            else
            {
                Console.WriteLine("Enter Number!!!");
                return 0;
            }
        }
    }
}
