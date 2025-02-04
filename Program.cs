using System;
using System.ComponentModel.Design;
using System.Globalization;
using System.Security.Cryptography;

namespace L20250203
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 ~ 13 Heart
            //14 ~ 26 Diamond
            //27 ~ 39 Clover
            //40 ~ 52 Spade
            int[] deck = new int[52];
            int[] playCards = new int[6];
            int[] playScores = new int[2];
            Initialize(deck);
            Shuffle(deck);
            Deal(deck, playCards);
            SumCard(playCards, playScores);
            PrintWin(playScores);

        }

        enum CardType
        {
            Heart,
            Diamond,
            Clover,
            Spade
        }


        static void Initialize(int[] deck)
        {
            for (int i = 0; i < deck.Length; i++)
            {
                deck[i] = i + 1;
            }
        }

        static void Shuffle(int[] deck)
        {
            Random randomMachine = new Random();

            //덱 3배정도 섞기 진행
            for (int i = 0; i < deck.Length * 3; i++)
            {
                //카드 섞는 중 
                int firstIndex = randomMachine.Next(0, deck.Length);
                int secondIndex = randomMachine.Next(0, deck.Length);
                int temp = deck[firstIndex];
                deck[firstIndex] = deck[secondIndex];
                deck[secondIndex] = temp;
            }
        }

        static void Deal(int[] deck, int[] playCards)
        {
            for (int i = 0; i < 6; i++)
            {
                int totalCardNum = deck[i];
                playCards[i] = totalCardNum;
            }
        }

        static void SumCard(int[] playCards, int[] playerSum)
        {
            for(int playerIndex = 0; playerIndex < playerSum.Length; playerIndex++)
            {
                //플레이어 수마다 3장씩
                int cardIndex = playerIndex * 3;
                int iCardSum = 0;
                for(int card = cardIndex; card < cardIndex+3; card++)
                {
                    int totalCardNum = playCards[card];
                    iCardSum += CheckCardScore(totalCardNum);
                    Console.WriteLine($"{card} 번째 카드는 {totalCardNum} {CheckCardType(totalCardNum)}_{NamingCard(totalCardNum)}  ");
                }
                playerSum[playerIndex] = iCardSum;
                Console.WriteLine(playerIndex+"번째 합은"+iCardSum);
            }
        }

        static void PrintWin(int[] scores)
        {
            int computerScore = scores[0];
            int playerScore = scores[1];
            Console.WriteLine($"컴퓨터 점수 {computerScore} 플레이어 점수 {playerScore}");
            //컴퓨터가 21점 넘었으면 플레이어 승리
            if (computerScore > 21)
            {
                Console.WriteLine("플레이어 승");
                return;
            }
            //컴퓨터가 안 넘었다면 플레이어 점수가 컴퓨터 보단 낮으면서 21 이하여야함 
            if(computerScore<=playerScore && playerScore <= 21)
            {
                Console.WriteLine("플레이어 승");
                return;
            }

            Console.WriteLine("컴퓨터 승");
        }

        static int CheckCardScore(int totalCardNum)
        {
            int cardNumber = NumberingCard(totalCardNum);
            int cardScore = cardNumber;
            if (11 <= cardNumber)
                cardScore = 10;
            return cardScore;

        }

        static int NumberingCard(int totalCardNum)
        {
           return ((totalCardNum - 1) % 13) + 1; 
        }

        static string NamingCard(int totalCardNum)
        {
            int cardNum = ((totalCardNum-1) % 13) + 1; //이러면 1~13으로받기 가능
            string cardName = cardNum.ToString();
            if (cardNum == 11)
            {
                cardName = "J";
            }
            else if (cardNum == 12)
            {
                cardName = "Q";
            }
            else if (cardNum == 13)
            {
                cardName = "K";
            }
            else if (cardNum == 1)
            {
                cardName = "A";
            }
            return cardName;
        }

        static string EmblemingCard(int totalCardNum)
        {
            int emblemNum = (totalCardNum - 1) / 13;
            string emblemName = "";
            if (emblemNum == 0)
            {
                emblemName = "Heart";
            }
            else if (emblemNum == 1)
            {
                emblemName = "Clover";
            }
            else if (emblemNum == 2)
            {
                emblemName = "Diamond";
            }
            else if (emblemNum == 3)
            {
                emblemName = "Spade";
            }
            return emblemName;
        }

        static CardType CheckCardType(int totalCardNum)
        {
            int emblemNum = (totalCardNum - 1) / 13;
            //스위치로 하나씩 찾아도됨.
            //switch (emblemNum)
            //{
            //    case 0:
            //        return CardType.Heart;
            //        break;
            //    case 1:
            //        break;
            //    case 2:
            //        break;
            //    case 3:
            //        break;
            //    default:
            //        break;

            //}
            return (CardType)emblemNum;
        }
    }
}
