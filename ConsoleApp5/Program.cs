using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[2];
            for (int i = 0; i < students.Length; i++)
            {
                string firstname = Console.ReadLine();
                string name = Console.ReadLine();
                string lastname = Console.ReadLine();
                string group = Console.ReadLine();
                int age = int.Parse(Console.ReadLine());
                Random rnd = new Random();
                int[] m1 = new int[rnd.Next(3, 6)];
                int[] m2 = new int[rnd.Next(3, 6)];
                int[] m3 = new int[rnd.Next(3, 6)];
                for (int j = 0; j < m1.Length; j++)
                {
                    m1[j] = rnd.Next(2, 6);
                }
                for (int j = 0; j < m2.Length; j++)
                {
                    m2[j] = rnd.Next(2, 6);
                }
                for (int j = 0; j < m3.Length; j++)
                {
                    m3[j] = rnd.Next(2, 6);
                }
                students[i] = new Student(firstname, name, lastname, group, age, m1, m2, m3);

            }
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i].ToString());

            }

        }
        /*
        static int Max (int x, int y)
        {
            return (x > y) ? x : y;
        }
        static void Main(string[] args)
        {

            /*
            Console.WriteLine("Enter A: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter B: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(Max(a,b));
            swap(ref a, ref b);
            Console.WriteLine(a + " " + b);
            int s = 0;
            Sum(a, b, out s);
            Console.WriteLine(s);
            int x;
            int.TryParse(Console.ReadLine(), out x);
            Console.WriteLine(x);
            int area;
            int perimeter;
            int y;
            /*
            int.TryParse(Console.ReadLine(), out y);
            GetData(x, y, out area, out perimeter);
            Console.WriteLine(Addition(5,7,5,5,2,7,8));
            int[] mas = new int[] { 4, 7, 9, 12, 6, 7, 6 };
            Console.WriteLine(Addition(mas));
            Console.WriteLine(area + " " + perimeter);
            var t = GetRect(7, 9);
            Console.WriteLine("Area="+t.Item1);
            Console.WriteLine("Permimeter="+t.Item2);
            
            try
            {

            }
            catch(Exception ex)
            {

            }
            finally
            {

            }
            */
    }
}
    /*
        private static (int, int) GetRect(int x, int y)
        {
            var result = (x * y, 2 * (x + y));
            return result;
        }

        static int  Addition (params int[] integers)
        {
            int res = 0;
            for (int i = 0; i < integers.Length; i++)
            {
                res += integers[i];
            }
            return res;
            
        }
        static void GetData (int x, int y, out int  area, out int perimeter)
        {
            area = x * y;
            perimeter = 2 * (x + y);
        }
        static void swap(int x, int y)
        {
                int temp = x;
                x = y;
                y = temp;
            
        }
            static void swap(ref int x, ref int y) 
            {
                int temp = x;
                x = y;
                y = temp;
            }
        static void Sum(int x, int y, out int a)
        {
            a = x + y;
        }
    }
}
    */
