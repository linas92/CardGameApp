using System;
using System.Collections.Generic;
using System.Linq;

namespace CardGameApp
{
// base class I'm going to be inheriting from 
    public abstract class Deck
    {
// this will be the full deck (when I create the deck I'm going to populate the full deck and pull everything to the full deck) protected allows me to access this in my overloaded classes
        protected List <PlayingCard> fullDeck = new List <PlayingCard> ();

        // this will be a list of playing cards which are available and I'll "pull" out of it whenever I deal cards (or request a card)
        protected List <PlayingCard> drawPile = new List <PlayingCard> ();

        // the cards will be "moved around" in different spots
        protected List <PlayingCard> discardPile = new List <PlayingCard> ();

        // this will "populate" a full deck with 52 cards (13 from each suit)
        protected void CreateDeck()
        {
            fullDeck.Clear ();

            // thinking about a for loop (suit = 0; suit <4; suit++) in a for loop (value = 0; val<13; val++) fullDeck add new playingCard
            for (int suit = 0; suit < 4; suit++)
            {
                for (int val = 0; val < 13; val++)
                {
                    // will have the cards come in like in the factory :)
                    fullDeck.Add(new PlayingCard { Suit = (int)(CardSuit)suit, Value = (int)(CardValue)val });
                }
            }
        }

// might shuffle the deck in a "different" way, that is why im making this Virtual
        public virtual void ShuffleDeck()
        {

// we don't want to ever create a new Random();
            var rnd = new Random();// not super duper random, wouldn't use it for something serious ( basically not safe)

// order by sorts the list based upon a value (basically assigns an each item in turn to a different random number)
            drawPile = fullDeck.OrderBy(x => rnd.Next()).ToList();
        }
        
// I need this abstract as I don't know how different games will be dealt
        public abstract List<PlayingCard> DealCards();

// in "most" games I need to "request" another card. For poker I'll need to override this
        public virtual PlayingCard RequestCard()
        {

// take does not "remove" and therefore we need to remove our output item.
            PlayingCard output = drawPile.Take(1).First();
            
            drawPile.Remove(output);

            return output;
        }
    }
}

