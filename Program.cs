namespace L20250203
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] data = new int[5, 5];
            int size = 5;
            for (int j = 1; j <= size; j++)
            {
                int blankCount = size - j;
                for (int i = 1; i <= blankCount; i++)
                {
                    Console.Write(" ");
                }
                for (int i = blankCount+1; i <= size; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            

        }
    }
}
