using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {


                //text

                int num1, num2;
                Console.WriteLine("Please, enter first number: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please, enter second number: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                Division division = new Division(num1, num2);
                Console.WriteLine(num1 + " / " + num2 + " = " + division.Divide());
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Error: Invalid Cast Exception");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: It is not allowed to divide by zero");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Format Exception");
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("Error: value is too long");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
            Console.ReadKey();
        }

    }

    public class Division
    {
        int firstNum;
        int secondNum;

        public Division(int firstNum, int secondNum)
        {
            this.firstNum = firstNum;
            this.secondNum = secondNum;
        }

        public int Divide()
        {
            var result = firstNum / secondNum;
            
            return result;
        }
    }
}
