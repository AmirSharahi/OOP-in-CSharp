using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1 , 2 , 3 , 4 , 5));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4 }));
        }
        static void UsePoints()
        {
            try
            {
                var point = new Point(10 , 10);
                point.Move(new Point(40 , 60));
                Console.WriteLine("Point is at ({0},{1})" , point.x , point.y);
                point.Move(100 , 200);
                Console.WriteLine("Point is at ({0},{1})" , point.x , point.y);
            }
            catch (Exception e)
            {
                Console.WriteLine("ey baba eror dad ke!");
            }


        }
        static void Main(string[] args)
        {
            //Video 9
            try
            {
                int num = int.Parse("abc");
            }
            catch (Exception e)
            {
                Console.WriteLine("nashod");
            }
            int number;
            var result = int.TryParse("abc", out number);
            if (result)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("nashod ke");
            }


            //ye morabbaa vase dele khodam dorost kardam
            /*var input = Convert.ToInt32(Console.ReadLine());
            var star = "*";
            for (int i = 0; i < input; i++)
            { 
                Console.WriteLine();
                if (i == 0 || i == input - 1)
                {
                    for (int j = 0; j < input; j++)
                    {
                        Console.Write(star + " ");
                    }
                }
                if (i < input - 1 && i > 0)
                {
                    for (int j = 0; j < 2*input; j++)
                    {
                        if (j == 0 || j == 2*input - 1)
                        {
                            Console.Write(star);
                        }
                        else if (j > 0 && j < 2*input-2)
                        {
                            Console.Write(" ");
                        }
                    }
                }
            }
            Console.WriteLine();*/
        }
    }
}