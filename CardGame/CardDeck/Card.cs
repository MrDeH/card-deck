using System;

namespace CardGame
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

        public String getValue()
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
