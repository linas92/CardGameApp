using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"What do you want to play?\nType 0 for Blackjack\nType 1 for Poker\nAnything else to exit");

            string playerInput = Console.ReadLine();

            if (playerInput == "0")
            {
                BlackJackGame();
            }
            else if (playerInput == "1")
            {
                PokerGame();
            }
            else
            {
                Console.WriteLine("Good day");
            }

            Console.ReadLine();
        }
        public static void BlackJackGame()
        {
            BlackjackDeck deck = new BlackjackDeck();

            var hand = deck.DealCards();

            foreach (var card in hand)
            {
                Console.WriteLine($"{card.Value} of {card.Suit}");
            }
        }
        public static void PokerGame()
        {
            PokerDeck deck = new PokerDeck();

            var hand = deck.DealCards();

            foreach (var card in hand)
            {
                Console.WriteLine($"{card.Value} of {card.Suit}");
            }
        }
    }
}

