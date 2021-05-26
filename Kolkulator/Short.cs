using static System.Console;
using static System.Math;

namespace Kolkulator
{
    internal class Short
    {
        private double _num1, _num2, _num3;
        private double _res1, _res2;

        private static void Paktc()
        {
            WriteLine("\nPress any key to continue");
            ReadKey();
            Clear();
        }

        public static void BadI()
        {
            Clear();
            WriteLine("Bad input the choice is 1-9");
            Paktc();
        }

        private static double Number()
        {
            double number;
            Write("#");
            while(!double.TryParse(ReadLine(), out number))
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
            _num1 = Number();
            WriteLine("type the second number and confirm it by <Enter>");
            _num2 = Number();
            _res1 = _num1 + _num2;
            Clear();
            WriteLine("the result of {0} + {1} = {2}", _num1, _num2, _res1);
            Paktc();
        }

        public void Subtraction()
        {
            Clear();
            WriteLine("type the first number and confirm it by <Enter>");
            _num1 = Number();
            WriteLine("type the first number and confirm it by <Enter>");
            _num2 = Number();
            _res1 = _num1 - _num2;
            Clear();
            WriteLine("the result of {0} - {1} = {2}", _num1, _num2, _res1);
            Paktc();
        }

        public void Multiplication()
        {
            Clear();
            WriteLine("type the first number and confirm it by <Enter>");
            _num1 = Number();
            WriteLine("type the first number and confirm it by <Enter>");
            _num2 = Number();
            _res1 = _num1 * _num2;
            Clear();
            WriteLine("the result of {0} * {1} = {2}", _num1, _num2, _res1);
            Paktc();
        }

        public void Division()
        {
            Clear();
            WriteLine("type the first number and confirm it by <Enter>");
            _num1 = Number();
            WriteLine("type the first number and confirm it by <Enter>");
            _num2 = Number();
            _res1 = _num1 / _num2;
            Clear();
            WriteLine("the result of {0} / {1} = {2}", _num1, _num2, _res1);
            Paktc();
        }

        public void Power()
        {
            Clear();
            WriteLine("type the number and confirm it with <Enter>");
            _num1 = Number();
            WriteLine("type number to which power and confirm it with <Enter>");
            _num2 = Number();
            _res1 = Pow(_num1, _num2);
            WriteLine("the result of {0} to the power of {1} = {2}", _num1, _num2, _res1);
            Paktc();
        }

        public void Root()
        {
            Clear();
            WriteLine("type the number and confirm it with <Enter>");
            _num1 = Number();
            WriteLine("type number 2(square), 3(cube) and confirm it with <Enter>");
            _num2 = Number();
            _res1 = Pow(_num1, 1.0 / _num2);
            Clear();
            switch (_num2)
            {
                case 0:
                    WriteLine("can't do to the power 0");
                    break;
                case 1:
                    WriteLine("the result is {0}", _num1);
                    break;
                case 2:
                    WriteLine("the result of square root of {0} = {1}", _num1, _res1);
                    break;
                case 3:
                    WriteLine("the result of cube root of {0} = {1}", _num1, _res1);
                    break;
                default:
                    WriteLine("the result of {0} root of {1} = {2}", _num2, _num1, _res1);
                    break;
            }
            Paktc();
        }

        public void QuadEqua()
        {
            Clear();
            WriteLine("type A in the equation and confirm it with <Enter>");
            _num1 = Number();//a
            if (_num1 == 0)
            {
                WriteLine("Can't divide by 0");
                Paktc();
            }
            else
            {
                WriteLine("type B in the equation and confirm it with <Enter>");
                _num2 = Number();//b
                WriteLine("type C in the equation and confirm it with <Enter>");
                _num3 = Number();//c
                if ((_num2 * _num2 - (4 * _num1 - _num3)) < 0)
                {
                    WriteLine("There is no way to root negative number");
                    Paktc();
                }
                else
                {
                    _res1 = (-_num2 + Sqrt(_num2 * _num2 - (4 * _num1 - _num3))) / (2 * _num1);//x1
                    _res2 = (-_num2 - Sqrt(_num2 * _num2 - (4 * _num1 - _num3))) / (2 * _num1);//x2
                    Clear();
                    WriteLine("the result of your Equation is\n" + $"x1 = {_res1:0.00}\n" + $"x2 = {_res2:0.00}");
                    Paktc();
                }
            }
        }

        public void HddSize()
        {
            Clear();
            WriteLine("type size in GB and confirm it with <Enter>");
            _num1 = Number();//a
            _res1 = _num1 * 1000.0 * 1000.0 * 1000.0 / 1024.0 / 1024.0 / 1024.0;
            Clear();
            WriteLine($"manufacturers say {_num1}GB but it's {_res1:0.00}");
            Paktc();
        }
    }
}
