using System.Globalization;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace Hands_of_cards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Cards
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new char[] { ':' }, System.StringSplitOptions.RemoveEmptyEntries);

            var dict = new Dictionary<string, string>();

            while (!input.Equals("JOKER"))
            {
                var cardspliter = new char[] { ',' };
                var name = input[0];
                var cards = input[1];
                var splitedCards = cards
                    .Split(cardspliter, StringSplitOptions.RemoveEmptyEntries);

                var cardPower = splitedCards[0];
                var cardSecondPower = splitedCards[1];
                dict[name] += GetCardPower(cardPower) + GetCardSecondPower(cardSecondPower);
                for (int i = 0; i < cards.Length; i++)
                {
                    
                }
                
                input = Console.ReadLine()
                    .Split(new char[] { ':' }, System.StringSplitOptions.RemoveEmptyEntries);

            }

        }

        public static int GetCardPower(string cards)
        {
            if (cards[0] != 'J' || cards[0] != 'D' || cards[0] != 'K' || cards[0] != 'A')
            {
                return cards[0];
            }
            switch (cards[0])
            {
                case '2':
                    return 2;
                case '3':
                    return 3;
                case '4':
                    return 4;
                case '5':
                    return 5;
                case '6':
                    return 6;
                case '7':
                    return 7;
                case '8':
                    return 8;
                case '9':
                    return 9;
                case 'J':
                    return 11;
                case 'Q':
                    return 12;
                case 'K':
                    return 13;
                case 'A':
                    return 14;
                default:
                    return int.Parse(cards);
            }
        }

        public static int GetCardSecondPower(string cards)
        {
            switch (cards[1])
            {
                case 'C':
                    return 1;
                case 'D':
                    return 2;
                case 'H':
                    return 3;
                case 'S':
                    return 4;
                default: return 0;
            }
        }
    }
}
