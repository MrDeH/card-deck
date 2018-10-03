using System;
using System.Collections.Generic;
using System.Linq;

namespace CardGame
{
    public class PokerDeck
    {
        private List<Card> cards = new List<Card>();
        private CardSuits[] cardSuits = { CardSuits.Clubs, CardSuits.Diamonds, CardSuits.Hearts, CardSuits.Spades };
        private int[] cardValues = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
    
        public PokerDeck()
        {
            foreach (var suit in cardSuits)
            {
                foreach (var value in cardValues)
                {
                    cards.Add(new Card(suit, value));
                }
            }
        }

        /// <summary>
        /// Search for a card in the deck
        /// </summary>
        /// <param name="cardSuit">Cardsuit</param>
        /// <param name="value">Value of card</param>
        /// <returns></returns>
        public bool searchForCard(CardSuits cardSuit, int value)
        {
            Card singleCard = cards.FirstOrDefault(card => card.Suit == cardSuit && card.Value == value);
            return singleCard != null;
        }

        /// <summary>
        /// Shuffle card deck
        /// </summary>
        public void shuffle()
        {
            cards = cards.OrderBy(card => Guid.NewGuid()).ToList();

            Console.WriteLine("Deck has been shuffled");
        }
        
        /// <summary>
        /// Get card value and suit string
        /// </summary>
        /// <returns>Card String</returns>
        public String getCard()
        {
            if (cards.Count == 0)
            {
                Console.WriteLine("Deck is empty");
                return null;
            }
            Card card = cards[0];

            cards.Remove(card);
            return card.ToString();
        }

        /// <summary>
        /// Display and remove N number of cards
        /// </summary>
        /// <param name="n">Number of Cards</param>
        public void makeHandOfCards(int n)
        {
            if (cards.Count < n)
            {
                Console.WriteLine("Only " + cards.Count + " left!");
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Card #" + (i + 1) + ": " + getCard());
                }
            }
        }

        /// <summary>
        /// Display all cards left in the deck
        /// </summary>
        public void displayCardsInDeck()
        {
            foreach (Card card in cards)
            {
                Console.WriteLine("Card: " + card.ToString());
            }
        }

        /// <summary>
        /// Overloading Display cards left in the deck to display n cards
        /// </summary>
        /// <param name="n">Number of cards</param>
        public void displayCardsInDeck(int n)
        {
            for(int i = 0; i < n ; i++)
            {
                Console.WriteLine("Card: " + cards[i].ToString());
            }
        }

        /// <summary>
        /// Count the number of cards left in the deck
        /// </summary>
        /// <returns>Number of cards</returns>
        public int getCount()
        {
            return cards.Count;
        }

        /// <summary>
        /// Display message with the number of cards left in the deck
        /// </summary>
        public void countCardsLeftInDeck()
        {
            Console.WriteLine("Number of Cards in deck: " + getCount() + Environment.NewLine);
        }
    }

}
