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
            //1 ~ 13 Heart
            //14 ~ 26 Diamond
            //27 ~ 39 Clover
            //40 ~ 52 Spade
            int[] deck = new int[52];
            for (int i = 0; i < deck.Length; i++)
            {
                deck[i] = i + 1;
            }
            Random randomMachine = new Random();

            //덱 3배정도 섞기 진행
            for (int i = 0; i < deck.Length*3; i++)
            {
                //카드 섞는 중 
                int firstIndex = randomMachine.Next(0, deck.Length);
                int secondIndex = randomMachine.Next(0, deck.Length);
                int temp = deck[firstIndex];
                deck[firstIndex] = deck[secondIndex];
                deck[secondIndex] = temp;
            }
            
            //뽑기
            for (int i = 1; i <= 8; i++)
            {
                int diceNum = deck[i - 1];

                //카드 쓰기
                int emblem = (diceNum-1) / 13; 
                int cardNum = diceNum % 13;

                string cardName = cardNum.ToString();
                if(cardNum == 11)
                {
                    cardName = "J";
                }
                else if (cardNum == 12)
                {
                    cardName = "Q";
                }
                else if (cardNum == 0)
                {
                    cardName = "K";
                }
                else if (cardNum == 1)
                {
                    cardName = "Ace";
                }

                string emblemName = "";
                if(emblem == 0)
                {
                    emblemName = "Heart";
                }
                else if (emblem == 1)
                {
                    emblemName = "Clover";
                }
                else if (emblem == 2)
                {
                    emblemName = "Diamond";
                }
                else if (emblem == 3)
                {
                    emblemName = "Spade";
                }

                Console.WriteLine(emblemName+" "+cardName);
            }

        }

    }
}
