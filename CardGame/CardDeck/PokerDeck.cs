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

        //Shuffle cards using random method
        public void shuffle()
        {
            //Optional Linq:
            cards = cards.OrderBy(card => Guid.NewGuid()).ToList();

            //Knuth Fisher-Yates shuffle
/*            Random rng = new Random();
            int n = this.cards.Count;

            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card tmp = cards[k];
                cards[k] = cards[n];
                cards[n] = tmp;
            }
*/
            Console.WriteLine("Deck has been shuffled");
        }
        
        //Get Card method
        public String getCard()
        {
            var card = cards[0];
            if (card == null)
            {
                Console.WriteLine("Deck is empty");
                return null;
            }
            cards.Remove(card);
            return card.getValue();
        }

        /*
         * Display the top n cards if available
         * Arguments: integer n = number of cards to display
        */
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

        //Display all cards left in the deck
        public void displayCardsInDeck()
        {
            foreach (Card card in cards)
            {
                Console.WriteLine("Card: " + card.getValue());
            }
        }

        /*
         * Overloading Display cards left in the deck to display n cards
         * Arguments: integer n = number of cards to display
        */
        public void displayCardsInDeck(int n)
        {
            for(int i = 0; i < n ; i++)
            {
                Console.WriteLine("Card: " + cards[i].getValue());
            }
        }

        //Count the number of cards left in the deck
        public int getCount()
        {
            return cards.Count;
        }

        public void countCardsLeftInDeck()
        {
            Console.WriteLine("Number of Cards in deck: " + getCount() + Environment.NewLine);
        }
    }

}
