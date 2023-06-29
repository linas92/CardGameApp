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

            PokerDeck deck = new PokerDeck();
            
            var hand = deck.DealCards();

            foreach (var card in hand)
            {
                Console.WriteLine($"{card.Suit} {card.Value}");
            }



            Console.ReadLine();
        }
    }
}

