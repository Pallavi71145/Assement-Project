using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gophika_batch_project2
{
    class MyClass
    {
        public static int input()
        {
            Console.WriteLine("******\nEnter \n2 for DOWN \n8 for UP \n4 for LEFT \n6 for RIGHT\n0 for EXIT\n********");
            var k = Convert.ToInt32(Console.ReadLine());
            return k;
        }
        public static void route(int k, int[,] a, int i, int j)
        {
            switch (k)
            {
                case 2:
                    a[i, j] = 0;
                    i++;
                    if (i < 5)
                    {
                        a[i, j] = 1;
                        MyClass.display(a);
                        var p = MyClass.input();
                        MyClass.route(p, a, i, j);
                    }
                    else
                    {
                        Console.WriteLine("Can\'t move ");
                        i--;
                        var p = MyClass.input();
                        MyClass.route(p, a, i, j);
                    }
                    break;
                case 4:
                    a[i, j] = 0;
                    j--;
                    if (j >= 0)
                    {
                        a[i, j] = 1;
                        MyClass.display(a);
                        var p = MyClass.input();
                        MyClass.route(p, a, i, j);
                    }
                    else
                    {
                        Console.WriteLine("Can\'t move ");
                        j++;
                        var p = MyClass.input();
                        MyClass.route(p, a, i, j);
                    }
                    break;
                case 6:
                    a[i, j] = 0;
                    j++;
                    if (j < 5)
                    {
                        a[i, j] = 1;
                        MyClass.display(a);
                        var p = MyClass.input();
                        MyClass.route(p, a, i, j);
                    }
                    else
                    {
                        Console.WriteLine("Can\'t move ");
                        j--;
                        var p = MyClass.input();
                        MyClass.route(p, a, i, j);
                    }
                    break;
                case 8:
                    a[i, j] = 0;
                    i--;
                    if (i >= 0)
                    {
                        a[i, j] = 1;
                        MyClass.display(a);
                        var p = MyClass.input();
                        MyClass.route(p, a, i, j);
                    }
                    else
                    {
                        Console.WriteLine("Can\'t move ");
                        i++;
                        var p = MyClass.input();
                        MyClass.route(p, a, i, j);
                    }
                    break;
                default:
                    Console.WriteLine("WRONG INPUT");
                    break;
            }
        }
        public static void display(int[,] a)
        {
            for (var i = 0; i < 5; i++)
            {
                for (var j = 0; j < 5; j++)
                {
                    Console.Write(a[i, j]);
                }
                Console.WriteLine();
            }
        }
        public static void Main(String[] args)
        {
            int[] sd = new int[25];
            sd[20] = 1;
            /*for(int i=0;i<25;i++)
                    System.out.print(sd[i]+" ,");
                */
            int[,] a = new int[5, 5];
            var x = 0;
            for (var p = 0; p < 5; p++)
            {
                for (var q = 0; q < 5; q++)
                {
                    a[p, q] = sd[x++];
                }
            }
            MyClass.display(a);
            var i = 2;
            var j = 2;
            var k = MyClass.input();
            MyClass.route(k, a, i, j);
        }
    }
}


