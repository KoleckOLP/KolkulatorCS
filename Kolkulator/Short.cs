using System;
using static System.Console;
using static System.Math;

namespace Kolkulator
{
    class Short
    {
        double num1, num2, num3;
        double res1, res2;

        public void Paktc()
        {
            WriteLine("\nPress any key to continue");
            ReadKey();
            Clear();
        }

        public void BadI()
        {
            Clear();
            WriteLine("Bad input the choice is 1-9");
            this.Paktc();
        }

        private double Number()
        {
            Double number;
            Write("#");
            while(!Double.TryParse(ReadLine(), out number))
            {
                WriteLine("That's not a valid number");
                Write("#");
            }
            return number;
        }

        public void Addition()
        {
            Clear();
            WriteLine("type the first number and confirm it by <Enter>");
            num1 = this.Number();
            WriteLine("type the second number and confirm it by <Enter>");
            num2 = this.Number();
            res1 = num1 + num2;
            Clear();
            WriteLine("the result of {0} + {1} = {2}", num1, num2, res1);
            this.Paktc();
        }

        public void Subtraction()
        {
            Clear();
            WriteLine("type the first number and confirm it by <Enter>");
            num1 = this.Number();
            WriteLine("type the first number and confirm it by <Enter>");
            num2 = this.Number();
            res1 = num1 - num2;
            Clear();
            WriteLine("the result of {0} - {1} = {2}", num1, num2, res1);
            this.Paktc();
        }

        public void Multiplication()
        {
            Clear();
            WriteLine("type the first number and confirm it by <Enter>");
            num1 = this.Number();
            WriteLine("type the first number and confirm it by <Enter>");
            num2 = this.Number();
            res1 = num1 * num2;
            Clear();
            WriteLine("the result of {0} * {1} = {2}", num1, num2, res1);
            this.Paktc();
        }

        public void Division()
        {
            Clear();
            WriteLine("type the first number and confirm it by <Enter>");
            num1 = this.Number();
            WriteLine("type the first number and confirm it by <Enter>");
            num2 = this.Number();
            res1 = num1 / num2;
            Clear();
            WriteLine("the result of {0} / {1} = {2}", num1, num2, res1);
            this.Paktc();
        }

        public void Power()
        {
            Clear();
            WriteLine("type the number and confirm it with <Enter>");
            num1 = this.Number();
            WriteLine("type number to which power and confirm it with <Enter>");
            num2 = this.Number();
            res1 = Pow(num1, num2);
            WriteLine("the result of {0} to the power of {1} = {2}", num1, num2, res1);
            this.Paktc();
        }

        public void Root()
        {
            Clear();
            WriteLine("type the number and confirm it with <Enter>");
            num1 = this.Number();
            WriteLine("type number 2(square), 3(cube) and confirm it with <Enter>");
            num2 = this.Number();
            res1 = Pow(num1, 1.0 / num2);
            Clear();
            if (num2 == 0)
            {
                WriteLine("can't do to the power 0");
            }
            else if (num2 == 1)
            {
                WriteLine("the result is {0}", num1);
            }
            else if (num2 == 2)
            {
                WriteLine("the result of square root of {0} = {1}", num1, res1);
            }
            else if (num2 == 3)
            {
                WriteLine("the result of cube root of {0} = {1}", num1, res1);
            }
            else
            {
                WriteLine("the result of {0} root of {1} = {2}", num2, num1, res1);
            }
            this.Paktc();
        }

        public void QuadEqua()
        {
            Clear();
            WriteLine("type A in the equation and confirm it with <Enter>");
            num1 = this.Number();//a
            if (num1 == 0)
            {
                WriteLine("Can't divide by 0");
                this.Paktc();
            }
            else
            {
                WriteLine("type B in the equation and confirm it with <Enter>");
                num2 = this.Number();//b
                WriteLine("type C in the equation and confirm it with <Enter>");
                num3 = this.Number();//c
                if ((num2 * num2 - (4 * num1 - num3)) < 0)
                {
                    WriteLine("There is no way to root negative number");
                    this.Paktc();
                }
                else
                {
                    res1 = (-num2 + Sqrt(num2 * num2 - (4 * num1 - num3))) / (2 * num1);//x1
                    res2 = (-num2 - Sqrt(num2 * num2 - (4 * num1 - num3))) / (2 * num1);//x2
                    Clear();
                    WriteLine(String.Format("the result of your Equation is\n" +
                                            "x1 = {0:0.00}\n" +
                                            "x2 = {1:0.00}", res1, res2));
                    this.Paktc();
                }
            }
        }

        public void HDDSize()
        {
            Clear();
            WriteLine("type size in GB and confirm it with <Enter>");
            num1 = this.Number();//a
            res1 = num1 * 1000.0 * 1000.0 * 1000.0 / 1024.0 / 1024.0 / 1024.0;
            Clear();
            WriteLine(String.Format("manufacturers say {0}GB but it's {1:0.00}", num1, res1));
            this.Paktc();
        }
    }
}
