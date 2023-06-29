using System;
using System.Collections.Generic;

namespace CardGameApp
{
    public class BlackjackDeck : Deck
    {
        public BlackjackDeck()
        {
            CreateDeck();
            ShuffleDeck();
        }
        public override List<PlayingCardModel> DealCards()
        {
            List<PlayingCardModel> output = new List<PlayingCardModel>();

// I request a card (this time just 2 as per blackjack rules) 2 times and I return the players "hand"
            for (int i = 0; i < 2; i++)
            {
                output.Add(DrawOneCard());
            }
            return output;
        }
    }
}

