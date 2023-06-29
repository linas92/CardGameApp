namespace CardGameApp
{
    public class PlayingCardModel
    {
// found my error. This should have not been an int, it should have been an Enum (CardSuit & CardValue)
        public CardSuit Suit { get; set; }
        public CardValue Value { get; set; }
    }
}

