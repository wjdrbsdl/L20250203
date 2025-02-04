using System;
using System.Security.Cryptography;

namespace L20250203
{

    internal class Program
    {
      
        //1. 1~52 배열
        //2. 임의 숫자 8개 
        //3. 중복 허용 불가 
        static void Main(string[] args)
        {
            int[] numbers = new int[52];
            for (int i = 0; i < 52; i++)
            {
                numbers[i] = i + 1;
            }

            for(int i = 1; i <= 8; i++)
            {
                bool randomFinding = true;
                //중복 안 된거 찾을때까지 반복
                while (randomFinding)
                {
                    int randomIndex = RandomNumberGenerator.GetInt32(52);
                    //배열 값이 0이 아니라면(중복이 아니라면)
                    if (numbers[randomIndex] != 0)
                    {
                        Console.WriteLine(numbers[randomIndex].ToString());//출력
                        numbers[randomIndex] = 0; //출력했다는 표시로 0
                        randomFinding = false;
                    }
                }

            }
            
        }

    }
}
