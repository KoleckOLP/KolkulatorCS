using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace Kolkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string cho;
            double num1, num2, num3;
            double res1, res2;

            Short shrt = new Short();

            while(true)
            {
                WriteLine("Kolulator by KoleckOLP, HorseArmore Inc. 18.03.2019");
                WriteLine("Choose 1-7\n\n" +
                          "1. Addition\n" +
                          "2. Subtraction\n" +
                          "3. Multiplication\n" +
                          "4. Division\n" +
                          "5. Power\n" +
                          "6. Root\n" +
                          "7. Quadratic Equasion\n" +
                          /*"8. Algebraic Expressions\n" +*/
                          "8. Real HDD/Flash space\n" +
                          "9. Quit");
                Write("#");
                cho = ReadLine();
                if(cho == "1") //Addition
                {
                    Clear();
                    WriteLine("type the first number and confirm it by <Enter>");
                    Write("#");
                    num1 = Double.Parse(ReadLine());
                    WriteLine("type the first number and confirm it by <Enter>");
                    Write("#");
                    num2 = Double.Parse(ReadLine());
                    res1 = num1 + num2;
                    Clear();
                    WriteLine("the result of {0} + {1} = {2}", num1, num2, res1);
                    shrt.Paktc();
                }
                else if(cho == "2") //Subtraction
                {
                    Clear();
                    WriteLine("type the first number and confirm it by <Enter>");
                    Write("#");
                    num1 = Double.Parse(ReadLine());
                    WriteLine("type the first number and confirm it by <Enter>");
                    Write("#");
                    num2 = Double.Parse(ReadLine());
                    res1 = num1 - num2;
                    Clear();
                    WriteLine("the result of {0} - {1} = {2}", num1, num2, res1);
                    shrt.Paktc();
                }
                else if (cho == "3") //Multiplication
                {
                    Clear();
                    WriteLine("type the first number and confirm it by <Enter>");
                    Write("#");
                    num1 = Double.Parse(ReadLine());
                    WriteLine("type the first number and confirm it by <Enter>");
                    Write("#");
                    num2 = Double.Parse(ReadLine());
                    res1 = num1 * num2;
                    Clear();
                    WriteLine("the result of {0} * {1} = {2}", num1, num2, res1);
                    shrt.Paktc();
                }
                else if (cho == "4") //Division
                {
                    Clear();
                    WriteLine("type the first number and confirm it by <Enter>");
                    Write("#");
                    num1 = Double.Parse(ReadLine());
                    WriteLine("type the first number and confirm it by <Enter>");
                    Write("#");
                    num2 = Double.Parse(ReadLine());
                    res1 = num1 / num2;
                    Clear();
                    WriteLine("the result of {0} / {1} = {2}", num1, num2, res1);
                    shrt.Paktc();
                }
                else if (cho == "5") //Power
                {
                    Clear();
                    WriteLine("type the number and confirm it with <Enter>");
                    Write("#");
                    num1 = Double.Parse(ReadLine());
                    WriteLine("type number to which power and confirm it with <Enter>");
                    Write("#");
                    num2 = Double.Parse(ReadLine());
                    res1 = Pow(num1, num2);
                    WriteLine("the result of {0} to the power of {1} = {2}", num1, num2, res1);
                    shrt.Paktc();
                }
                else if (cho == "6") //Root
                {
                    Clear();
                    WriteLine("type the number and confirm it with <Enter>");
                    Write("#");
                    num1 = Double.Parse(ReadLine());
                    WriteLine("type number 2(square), 3(cube) and confirm it with <Enter>");
                    Write("#");
                    num2 = Double.Parse(ReadLine());
                    res1 = Pow(num1, 1.0/num2);
                    Clear();
                    if(num2 == 0)
                    {
                        WriteLine("can't do to the power 0");
                    }
                    else if(num2 == 1)
                    {
                        WriteLine("the result is {0}", num1);
                    }
                    else if(num2 == 2)
                    {
                        WriteLine("the result of square root of {0} = {1}", num1, res1);
                    }
                    else if(num2 == 3)
                    {
                        WriteLine("the result of cube root of {0} = {1}", num1, res1);
                    }
                    else
                    {
                        WriteLine("the result of {0} root of {1} = {2}", num2, num1, res1);
                    }
                    shrt.Paktc();
                }
                else if(cho == "7") //Quadratic Equasion
                {
                    Clear();
                    WriteLine("type A in the equasion and confirm it with <Enter>");
                    Write("#");
                    num1 = Double.Parse(ReadLine());//a
                    WriteLine("type B in the equasion and confirm it with <Enter>");
                    Write("#");
                    num2 = Double.Parse(ReadLine());//b
                    WriteLine("type C in the equasion and confirm it with <Enter>");
                    Write("#");
                    num3 = Double.Parse(ReadLine());//c
                    res1 = (-num2 + Sqrt(num2 * num2 - 4 * num1 - num3)) / (2 * num1);//x1
                    res2 = (-num2 - Sqrt(num2 * num2 - 4 * num1 - num3)) / (2 * num1);//x2
                    Clear();
                    WriteLine(String.Format("the result of your Equasion is\n" +
                                            "x1 = {0:0.00}\n" +
                                            "x2 = {1:0.00}", res1, res2));
                    shrt.Paktc();
                }
                else if (cho == "8")
                {
                    Clear();
                    WriteLine("type size in GB and confirm it with <Enter>");
                    Write("#");
                    num1 = Double.Parse(ReadLine());//a
                    res1 = num1 * 1000.0 * 1000.0 * 1000.0 / 1024.0 / 1024.0 / 1024.0;
                    Clear();
                    WriteLine(String.Format("manufacturers say {0}GB but it's {1:0.00}", num1, res1));
                    shrt.Paktc();
                }
                else if (cho == "9") //Quit
                {
                    break;
                }
                else
                {
                    Clear();
                    WriteLine("Wrong input, the choice is 1-7");
                }
            }
        }
    }
}
