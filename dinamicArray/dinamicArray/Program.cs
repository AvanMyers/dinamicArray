using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dinamicArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arrayMax = 0;
            int arraySum = 0;
            bool isWork = true;
            int[] array = new int[0];
            const string CommandNumber = "number";
            const string CommandSum = "sum";
            const string CommandExit = "exit";

            while (isWork)
            {
                Console.WriteLine();
                Console.Write("Введите number что бы добавить число для сложение\n Введите sum - для сложения вписанных чисел \n" +
                "Введите exit - для выхода из программы:");

                switch (Console.ReadLine())
                {
                    case (CommandNumber):
                        Console.Write("Введите число которое хотите добавить:");
                        int[] tempArray = new int[array.Length + 1];
                        for (int i = 0; i < array.Length; i++)
                        {
                            tempArray[i] = array[i];
                        }
                        tempArray[tempArray.Length - 1] = Convert.ToInt32(Console.ReadLine());
                        array = tempArray;
                        break;
                    case (CommandSum):
                        arraySum = 0;
                        for (int i = 0; i < array.Length; i++)
                        {
                            arraySum += array[i];
                            Console.Write(array[i]);
                            if (i < array.Length - 1)
                            {
                                Console.Write(" + ");
                            }
                            else
                            {
                                Console.WriteLine(" = " + arraySum);
                            }
                        }
                        break;
                    case (CommandExit):
                        isWork = false;
                        break;
                }
            }
        }
    }
}
