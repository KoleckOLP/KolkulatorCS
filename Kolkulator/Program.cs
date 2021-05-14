using static System.Console;

namespace Kolkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Short shrt = new Short();

            while(true)
            {
                char cho;

                WriteLine("Kolulator by KoleckOLP, HorseArmore Inc.");
                WriteLine("Choose 1-7\n\n" +
                          "1. Addition\n" +
                          "2. Subtraction\n" +
                          "3. Multiplication\n" +
                          "4. Division\n" +
                          "5. Power\n" +
                          "6. Root\n" +
                          "7. Quadratic Equasion\n" +
                          // "8. Algebraic Expressions\n" +
                          "8. Real HDD/Flash space\n" +
                          "9. Quit");
                Write("#");
                cho = ReadKey().KeyChar;
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
                else if(cho == '7') // Quadratic Equasion
                {
                    shrt.QuadEqua();
                }
                else if (cho == '8')
                {
                    shrt.HDDSize();
                }
                else if (cho == '9') // Quit
                {
                    break;
                }
                else
                {
                    shrt.BadI();
                }
            }
        }
    }
}
