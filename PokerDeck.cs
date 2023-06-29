using System.Collections.Generic;

namespace CardGameApp
{
    public class PokerDeck : Deck
    {
// when I first "come into" this app, I want to create and then shuffle the deck (obviously)
        public PokerDeck()
        {
            CreateDeck();
            ShuffleDeck();
        }
        public override List<PlayingCard> DealCards()
        {
            List<PlayingCard> output = new List<PlayingCard>();

// I request a card 5 times and the end I return the players "hand"
            for (int i = 0; i < 5; i++)
            {
                output.Add(DrawOneCard());
            }
            return output;
        }
    }
}

