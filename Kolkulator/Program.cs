using static System.Console;

namespace Kolkulator
{
    internal static class Program
    {
        private static void Main()
        {
            var shrt = new Short();

            while(true)
            {
                WriteLine("Kolulator by KoleckOLP, HorseArmored Inc.");
                WriteLine("Choose 1-7\n\n" +
                          "1. Addition\n" +
                          "2. Subtraction\n" +
                          "3. Multiplication\n" +
                          "4. Division\n" +
                          "5. Power\n" +
                          "6. Root\n" +
                          "7. Quadratic Equation\n" +
                          // "8. Algebraic Expressions\n" +
                          "8. Real HDD/Flash space\n" +
                          "9. Quit");
                Write("#");
                var cho = ReadKey().KeyChar;
                if(cho == '1') // Addition
                {
                    shrt.Addition();
                }
                else if(cho == '2') // Subtraction
                {
                    shrt.Subtraction();
                }
                else if (cho == '3') // Multiplication
                {
                    shrt.Multiplication();
                }
                else if (cho == '4') // Division
                {
                    shrt.Division();
                }
                else if (cho == '5') // Power
                {
                    shrt.Power();
                }
                else if (cho == '6') // Root
                {
                    shrt.Root();
                }
                else if(cho == '7') // Quadratic Equation
                {
                    shrt.QuadEqua();
                }
                else if (cho == '8')
                {
                    shrt.HddSize();
                }
                else if (cho == '9') // Quit
                {
                    break;
                }
                else
                {
                    Short.BadI();
                }
            }
        }
    }
}
