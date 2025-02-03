using System;

namespace L20250203
{
    internal class Program
    {
        static int[,] data = new int[10, 10];
        static void Initialize()
        {
            int num = 1;
      
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    data[i, j] = num;
                    num++;

                }
            }
        }

        static void Print()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(data[i, j] + "\t");

                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {

            //초기화
            Initialize();

            //출력
            Print();
    
        }
    }
}
