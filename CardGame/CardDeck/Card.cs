using System;

namespace CardGame
{
    public class Card : IComparable
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

        /// <summary>
        /// Future use to compare cards
        /// </summary>
        /// <param name="obj">Card object</param>
        /// <returns>int</returns>
        public int CompareTo(object obj)
        {
            if (Value.CompareTo(obj) == 0) 
            {
                return Suit.CompareTo(obj);
            }
            return Value.CompareTo(obj);
        }


        /// <summary>
        /// String value for int numbers above 10
        /// </summary>
        /// <returns>String</returns>
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
