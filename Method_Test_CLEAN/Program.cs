using System; //Import Components from system;

namespace Method_Test_CLEAN //namespace for whole classes to other classes;
{
    class Program //Class for this program;
    {
        //Main program method;
        static void Main()
        {
            //Declare for n value;
            int n;
            again_n:
            //Use try and catch to catch an exceptions when user input wrong format;
            try
            {
                Console.Write("\n\tEnter n: ");
                n = int.Parse(Console.ReadLine());
            }
            catch (Exception err)
            {
                //Console.WriteLine(err.Message); //Show error Message...
                Console.Clear();
                goto again_n;
            }

            again_main_menu:
            //Show Main-Menu
            Console.Write("\n \t\t Main Menu\n");
            Console.Write("\t\t-----------\n");
            Console.Write("\n\t1. 1-2+3-4+5.....+-(n) \n");
            Console.Write("\n\t2. 1*2*3*4*5.....*n \n");
            Console.Write("\n\t3. 1+1+2+3+5.....(n-1)+(n-2) \n");
            Console.Write("\n\t4. 1!/1+2!/1+3!/2+4!/3+5!/5.....+(n!)/((n-1)+(n-2)) \n");

            //Declare for option number;
            int opt_num;
            again_opt_num:
            //Use try and catch to catch an exceptions when user input wrong format;
            try
            {
                Console.Write("\n\tPlease choose option number (n = {0}): ", n);
                opt_num = int.Parse(Console.ReadLine());

            }
            catch (Exception err)
            {
                //Console.WriteLine(err.Message); //Show error Message...
                goto again_opt_num;
            }

            switch (opt_num)
            {
                case 1:
                    //Show result 1;
                    printline("*", 40, "\n\t" ,"\n");
                    Console.Write("\tSum-Minus => ");
                    SumMinus(n); //SumMinus = 1-2+3-4+5...+-(n);
                    printline("*", 40, "\n\t", "\n");
                    break;
                case 2:
                    //Show result 2;
                    printline("*", 40, "\n\t", "\n");
                    Console.Write("\tPower-N => ");
                    PowN(n); //PowN = 1*2*3*4*5...*n;
                    printline("*", 40, "\n\t", "\n");
                    break;
                case 3:
                    //Show result 3;
                    printline("*", 40, "\n\t", "\n");
                    Console.Write("\tFibonacci => ");
                    Fibonacci(n); //Fibonacci = 1+1+2+3+5...(n-1)+(n-2);
                    printline("*", 40, "\n\t", "\n");
                    break;
                case 4:
                    //Show result 4;
                    printline("*", 40, "\n\t", "\n");
                    Console.Write("\tFact-Fibonacci => ");
                    FactFibonacci(n); //FactFibonacci = 1!/1+2!/1+3!/2+4!/3+5!/5.....+(n!)/((n-1)+(n-2));
                    printline("*", 40, "\n\t", "\n");
                    break;
                default:
                    //Goto again option number;
                    goto again_opt_num;
                    break;
            }
            
            //Show Sub-Menu;
            Console.Write("\n \t\t Sub Menu\n");
            Console.Write("\t\t----------\n");
            Console.Write("\n\ta. Choose number again\n");
            Console.Write("\n\tb. Enter n again\n");
            Console.Write("\n\tc. Exit\n");

            //Declare for option char;
            char opt_char;
            again_opt_char:
            //Use try and catch to catch an exceptions when user input wrong format;
            try
            {
                Console.Write("\n\tEnter option char: ");
                opt_char = char.Parse(Console.ReadLine());
                opt_char = Char.ToLower(opt_char); //Convert to Lower case;
            }
            catch (Exception err)
            {
                //Console.WriteLine(err.Message); //Show error Message...
                goto again_opt_char;
            }

            switch (opt_char)
            {
                case 'a':
                    //Go back to enter option number again;
                    Console.Clear();
                    goto again_main_menu;
                    break;
                case 'b':
                    //Go back to enter n value again;
                    Console.Clear();
                    goto again_n;
                    break;
                case 'c':
                    System.Environment.Exit(0); //Exit the program;
                    break;
                default:
                    //Go to agian option char, if no char correct above;
                    goto again_opt_char;
                    break;
            }
            
            Console.Read();
        }
        
        //SumMinus = 1-2+3-4+5...+-(n);
        private static void SumMinus(int n)
        {
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("-" + i);
                    sum -= i;
                }
                else
                {
                    if (i == 1)
                    {
                        Console.Write(i);
                        sum += i;
                    }
                    else
                    {
                        Console.Write("+" + i);
                        sum += i;
                    }
                }
            }
            Console.Write(" = " + sum);
        }

        //PowN = 1*2*3*4*5...*n;
        private static void PowN(int n)
        {
            double powX = 1;
            if (n != 0 && n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.Write(i + "*");
                    powX *= i;
                }
            }
            else
            {
                Console.Write("0");
            }
            Console.Write("\b = " + powX);
        }

        //Fibonacci = 1+1+2+3+5...(n-1)+(n-2);
        private static void Fibonacci(int n)
        {
            int a = 1, b = 1, c;
            double Fib = a + b;
            if (n != 0)
            {
                if (n == 1)
                {
                    Console.Write("1");
                }
                else
                {
                    Console.Write(a + "+" + b);
                    for (int i = 0; i < n - 2; i++)
                    {
                        c = a + b;
                        a = b;
                        b = c;
                        Fib += c;
                        Console.Write("+" + c);
                    }
                    Console.Write(" = " + Fib);
                }
            }
            else
            {
                Console.Write("0");
            }

        }

        //FactFibonacci = 1!/1+2!/1+3!/2+4!/3+5!/5.....+(n!)/((n-1)+(n-2));
        private static void FactFibonacci(int n)
        {
            double factFib = 0, fact = 1;
            int a = 1, b = 1, c, d = 1;
            for (int j = 1; j <= n; j++)
            {
                c = a + b;
                a = b;
                if (j > 2)
                {
                    fact *= j;
                    factFib += fact / c;
                    b = c;
                    Console.Write(j + "!/" + c + "+");
                }
                else
                {
                    Console.Write(j + "!/" + d + "+");
                    fact *= j;
                    factFib += fact / d;
                }
            }
            Console.Write("\b = " + factFib);
        }

        private static void printline(string text, int n, string st_space, string ed_space)
        {
            Console.Write(st_space);
            for (int i = 0; i < n; i++)
            {
                Console.Write(text);
            }
            Console.Write(ed_space);
        }

    }
}
