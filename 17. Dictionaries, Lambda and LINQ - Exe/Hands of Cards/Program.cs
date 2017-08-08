using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            var players = new Dictionary<string, int>();

            var input = Console.ReadLine();

            var oldPlayersHands = new Dictionary<string, List<string>>();

            while (input != "JOKER")
            {
                var playerAndHand = input.Split(':');

                var playerName = playerAndHand[0];
                var playerHand = playerAndHand[1].Split(' ', ',').Where(h => h != "").Distinct().ToList();

                if (players.ContainsKey(playerName))
                {
                    foreach (var card in oldPlayersHands[playerName])
                    {
                        if (playerHand.Contains(card))
                        {
                            playerHand.Remove(card);
                        }
                    }

                    players[playerName] += CalcPowerOfPlayerHand(playerHand);
                }
                else
                {
                    oldPlayersHands[playerName] = playerHand;
                    players[playerName] = CalcPowerOfPlayerHand(playerHand);
                }

                input = Console.ReadLine();
            }

            foreach (var player in players)
            {
                Console.WriteLine($"{player.Key}: {player.Value}");
            }
        }

        static int CalcPowerOfPlayerHand(List<string> playerHand)
        {
            int totalHandValue = 0;

            foreach (var card in playerHand)
            {
                var cardPower = card.First();
                var cardType = card.Last();

                int cardPowerValue = 0;
                int cardTypeValue = 0;

                if (cardPower >= '2' && cardPower <= '9')
                {
                    cardPowerValue += cardPower - '0';
                }
                else if (card.Contains("10"))
                {
                    cardPowerValue += 10;
                }
                else
                {
                    switch (cardPower)
                    {
                        case 'J': cardPowerValue += 11; break;
                        case 'Q': cardPowerValue += 12; break;
                        case 'K': cardPowerValue += 13; break;
                        case 'A': cardPowerValue += 14; break;
                    }
                }

                switch (cardType)
                {
                    case 'S': cardTypeValue += 4; break;
                    case 'H': cardTypeValue += 3; break;
                    case 'D': cardTypeValue += 2; break;
                    case 'C': cardTypeValue += 1; break;
                }

                totalHandValue += cardPowerValue * cardTypeValue;
            }

            return totalHandValue;
        }
    }
}
