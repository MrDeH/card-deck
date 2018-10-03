using System;

namespace CardGame
{
    public class Card
    {
        private readonly CardSuits _cardSuit;
        private readonly int _cardValue;

        public Card(CardSuits cardSuit, int cardValue)
        {
            _cardSuit = cardSuit;
            _cardValue = cardValue;
        }

        public CardSuits Suit { get { return _cardSuit; } }
        public int Value { get { return _cardValue; } }

        public override String ToString()
        {
            String cardValue;
        
            switch (_cardValue)
            {
                case 11:
                    cardValue = "Jack";
                    break;
                case 12:
                    cardValue = "Queen";
                    break;
                case 13:
                    cardValue = "King";
                    break;
                case 14:
                    cardValue = "Ace";
                    break;
                default:
                    cardValue = _cardValue.ToString();
                    break;
            }
            return cardValue + " of " + _cardSuit;
        }
    }
}
