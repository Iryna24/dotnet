using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                Console.WriteLine("Please, enter length of array:");
                //MyArray.lengthOfArray = Convert.ToInt32(Console.ReadLine());
                int lengthOfArray = Convert.ToInt32(Console.ReadLine());

                MyArray myArray = new MyArray(lengthOfArray);

                //for (int i = 0; i < MyArray.lengthOfArray; i++)
                //{
                //    Console.WriteLine("Please, enter " + i + " element of array:");
                //    MyArray.ElementOfArray = Convert.ToInt32(Console.ReadLine());
                //    myArray.array[i] = MyArray.ElementOfArray;
                //}

                for (int i = 0; i < lengthOfArray; i++)
                {
                    Console.WriteLine("Please, enter " + i + " element of array:");
                    int ElementOfArray = Convert.ToInt32(Console.ReadLine());
                    myArray.array[i] = ElementOfArray;
                }

                Console.WriteLine("Please, enter K value:");
                int K = Convert.ToInt32(Console.ReadLine());
               
                myArray.ArithmeticalAverage(K);

                Console.WriteLine("First element of array: "+ myArray.array[0]);
                myArray.array[0] = K;
                Console.WriteLine("Changed first element of array: " + myArray.array[0]);

            }
            catch (FormatException)
            {
                Console.WriteLine("Error: enter integer number");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow Exception: value is too long or too small");
            }
            
            Console.ReadKey();
            
        }
    }

   class MyArray
    {
        public int lengthOfArray;
       
        //public int[] array = new int[lengthOfArray];
        public int[] array;

        public MyArray(int length)
        {
            array = new int[length];
            lengthOfArray = length;
        }
       
        public void ArithmeticalAverage(int K)
       {
            int result = 0;
            int divider = 0;
            int sum = 0;

            
            for (int j = 0; j < lengthOfArray; j++)
            {
                if (K > 0)
                {
                    if (array[j] > 0 && array[j] > K)
                    {
                        sum = sum + array[j];
                        divider = divider + 1;
                    }

                    result = sum / divider;

                    
                }
                else
                {
                    if (array[j] < K)
                    {
                        result = result + array[j];
                    }
                    
                }
                
            }
            Console.WriteLine("Arithmetical Average for positive numbers from array is: " + result);

        }
       




    }
}





//// 1) В программу вводится одномерный массив целых чисел. Вводится с клавиатуры – в
//начале размер, потом по очереди элементы.При вводе необходимо отметить какой
//элемент вводится.Ввод должен быть проверен на корректность, массив хранится в
//отдельном классе, метод которого вычисляет среднее арифметическое положительных
//элементов, значение которых больше К(также с клавиатуры) и заменить им первый
//элемент массива.Показать первый элемент массива.

//Расширить предыдущую программу путем ввода состояния расчета.Для
//положительного К – оставляем алгоритм неизменным, для отрицательного – берем
//сумму всех элементов, которые меньше К и заменяем ей первый элемент.