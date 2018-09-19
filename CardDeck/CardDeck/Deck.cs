using System;
using System.Collections.Generic;
using System.Text;

namespace CardDeck
{
    class Deck
    {
        public List<Card> Cards;
        private CardSuits[] cardSuits = { CardSuits.Clubs, CardSuits.Diamonds, CardSuits.Hearts, CardSuits.Spades };
    private int[] cardValues = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

    private void BuildDeck()
        {
            Cards = null;
            foreach(var suit in cardSuits)
            {
                foreach (var value in cardValues)
                {
                    Cards.Add(new Card(suit, value));
                }
            }
        }
    }

    //shuffle
    //pop n cards
    //count cards in deck
    //Look at next card
}
