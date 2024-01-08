using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWithException
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                Console.WriteLine("Введите целое число:");
                int firstNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите целое число:");
                int secondNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите код операции:\n1 - сложение\n2 - вычитание\n3 - произведение\n4 - частное");
                int operationCode = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Выбранный тип операции: {0}", operationCode);
                double result = 0;
                switch(operationCode)
                {
                    case 1:
                        result = firstNumber + secondNumber;
                        break;
                    case 2:
                        result = firstNumber - secondNumber;
                        break;
                    case 3:
                        result = firstNumber * secondNumber;
                        break;
                        
                    case 4:
                        if (secondNumber == 0)
                        {
                            throw new DivideByZeroException();
                        }
                        result = (double)firstNumber / secondNumber;
                        break;
                    default:
                        throw new InvalidOperationException("Нет операции с указанным кодом");
                }
                Console.WriteLine("Результат = {0,1:f2}",result);
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Деление на ноль невозможно");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();


        }
    }
}
