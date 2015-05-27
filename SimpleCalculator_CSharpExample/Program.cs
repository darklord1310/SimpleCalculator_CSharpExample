using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator_CSharpExample
{
    class Program
    {

        public static double div(double num1,double num2)
        {
            return num1 / num2;
        }

        public static double add(double num1, double num2)
        {
            return num1 + num2;
        }

        public static double subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        public static double mul(double num1, double num2)
        {
            return num1 * num2;
        }

        public static double[] sqrRoot(double num1, double num2, double[] answer)
        {
            answer[0] = Math.Sqrt( num1);
            answer[1] = Math.Sqrt( num2);
            return answer;
        }
        public static void exectuteSelection(int selection, double num1, double num2)
        {
            double answer1;
            double[] num = new double[2];
             switch (selection)
                    {
                        case 1: answer1 = add(num1, num2);
                                Console.WriteLine("Result : " + num1 + " + " + num2 + " = " + answer1);
                                break;
                        case 2: answer1 = subtract(num1, num2);
                                Console.WriteLine("Result : " + num1 + " - " + num2 + " = " + answer1);
                                break;
                        case 3: answer1 = mul(num1, num2);
                                Console.WriteLine("Result : " + num1 + " x " + num2 + " = " + answer1);
                                break;
                        case 4: answer1 = div(num1, num2);
                                if(num2 == 0)
                                    Console.WriteLine("Result cannot be generated due to divide by 0");
                                else
                                    Console.WriteLine("Result : " + num1 + " / " + num2 + " = " + answer1);
                                break;
                        case 5: sqrRoot(num1, num2, num);
                                Console.WriteLine("Result : sqrRoot " + num1 + " = " + num[0]);
                                Console.WriteLine("Result : sqrRoot " + num2 + " = " + num[1]);
                                break;
                        case 6: Environment.Exit(0);            //exit application
                                break;
                    }
        }

        public static void printMenu()
        {
            Console.WriteLine("Please select any operation of below: ");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Square Root");
            Console.WriteLine("6. Exit");
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            double num1 = 0, num2 = 0;
            int selection;
            char isAgain, isCont;

            do{
                Console.Clear();
                printMenu();
                Console.Write("Enter your selection: ");
                selection = Convert.ToInt32(Console.ReadLine());

                double[] num = new double[2];                           //array declaration, list declaration is similar to this
                List<double> doubleNums = new List<double>();           //new data storage, the number of data to be stored not
                                                                        //needed to be define at start, no size limit
                //eg can add how many times as you want
                doubleNums.Add(num1);
                doubleNums.Add(num2);
                doubleNums.Add(num1);
                doubleNums.Add(num2);
                doubleNums.Add(num1);

                for (int i = 0; i < num.Length; i++ )                   //typical for loop in c
                {
                    Console.WriteLine(num[i]);
                }

                foreach(double n in doubleNums)                         //looping which you no need to define the size, useful for list
                {
                    Console.WriteLine(n);
                }

                    do
                    {
                        Console.Clear();
                        Console.Write("Please enter number 1 : ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Please enter number 2 : ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(); Console.WriteLine();
                        exectuteSelection(selection, num1, num2);
                        Console.WriteLine(); Console.WriteLine();
                        Console.Write("Do you want to continue with other values? (Y/N): ");
                        isAgain = Convert.ToChar(Console.ReadLine());
                    } while (isAgain == 'y');

                Console.Write("Do you want to continue with other operations? (Y/N): ");
                 isCont = Convert.ToChar(Console.ReadLine());
            }while(isCont == 'y');
        }
    }
}
