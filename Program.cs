namespace L20250203
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] data = new int[10,10];

            int num = 1;
            //초기화
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    data[i, j] = num;
                    num++;
                    
                }
            }

            //출력
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(data[i, j] + "\t");

                }
                Console.WriteLine();
            }
        }
    }
}
