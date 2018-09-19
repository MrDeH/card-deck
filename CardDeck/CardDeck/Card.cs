namespace CardDeck
{
    public class Card
    {
        private CardSuits _cardSuit { get;}
        private int _cardValue { get; }

        public Card(CardSuits cardSuit, int cardValue)
        {
            _cardSuit = cardSuit;
            _cardValue = cardValue;
        }
    }
}
