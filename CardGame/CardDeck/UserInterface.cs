using System;

namespace CardGame
{
    public class UserInterface
    {
        private PokerDeck deck;
        private bool quitFlag;

        public UserInterface()
        {
            Console.WriteLine("Start Card Game Application");
            startMenu();
        }

        /// <summary>
        /// Conditional start menu
        /// </summary>
        public void startMenu() {
            Console.WriteLine("1. Build new Deck");
            if (checkDeck())
            {
                Console.WriteLine("2. Shuffle Deck");
                Console.WriteLine("3. Grab Number of Cards");
                Console.WriteLine("4. Display Number of Cards");
                Console.WriteLine("5. Display Remaining Cards");
                Console.WriteLine("6. Display Card Count in the Deck");
                Console.WriteLine("7. Search for a card in the Deck");
                Console.WriteLine("8. Quit" + Environment.NewLine);
            }
            else
            {
                Console.WriteLine("2. Quit" + Environment.NewLine);
            }
            Console.WriteLine("Enter an option:");
            menuOption();
        }

        /// <summary>
        /// Menu Option logic
        /// </summary>
        private void menuOption()
        {
            int value;
            string input = Console.ReadLine();
            if (!int.TryParse(input, out value))
            {
                Console.WriteLine("Invalid Number Type");
                return;
            }

            if (checkDeck())
                {
                    switch (value)
                    {
                        case 1:
                            deck = new PokerDeck();
                            deckBuiltMessage();
                            break;
                        case 2:
                            deck.shuffle();
                            break;
                        case 3:
                            getCards();
                            break;
                        case 4:
                            displayCards();
                            break;
                        case 5:
                            deck.displayCardsInDeck();
                            break;
                        case 6:
                            deck.countCardsLeftInDeck();
                            break;
                        case 7:
                            cardSearch();
                            break;
                        case 8:
                            quit();
                            break;
                        default:
                            break;
                    }
            }
            else
            {
                switch (value)
                {
                    case 1:
                        deck = new PokerDeck();
                        deckBuiltMessage();
                        break;
                    case 2:
                        quit();
                        break;
                    default:
                        break;
                }
            }
          
            if (!quitFlag)
            {
                continuePrompt();
                Console.Clear();
                startMenu();
            }
        }

        /// <summary>
        /// Check whether the deck has been built
        /// </summary>
        /// <returns>boolean</returns>
        private bool checkDeck()
        {
            return deck != null && deck.getCount() > 0;
        }

        public void continuePrompt(){
            Console.WriteLine(Environment.NewLine + "Press any key to continue...");
            Console.ReadKey();
        }


        /// <summary>
        /// Message output when deck is built
        /// </summary>
        private void deckBuiltMessage()
        {
            deck.countCardsLeftInDeck();
        }

        /// <summary>
        /// Quit app function
        /// </summary>
        private void quit()
        {
            quitFlag = true;
        }

        /// <summary>
        /// Prompt message for reading in number input and returning whether it is valid
        /// </summary>
        /// <returns>int<returns>
        private int promptNumber() {
            int number;

            Console.WriteLine("How many cards would you like? ");

            string numberInput = Console.ReadLine();

            if (!int.TryParse(numberInput, out number))
            {
                Console.WriteLine("Invalid Number Type");
                return -1;
            }

            if (number < 1)
            {
                Console.WriteLine("Number has to be greater than 0");
                return -1;
            }
            return number;
        }


        /// <summary>
        /// Function to get number of cards from the top of the deck
        /// </summary>
        private void getCards()
        {
            int value = promptNumber();
            if(value != -1)
            {
                deck.makeHandOfCards(value);
            }
        }


        /// <summary>
        /// Display a number of cards from the top of the deck
        /// </summary>
        private void displayCards()
        {
            int value = promptNumber();
            if (value != -1)
            {
                deck.displayCardsInDeck(value);
            }
        }

        /// <summary>
        /// Card Suit options
        /// </summary>
        /// <param name="number">int</param>
        /// <returns>CardSuit</returns>
        private CardSuits getCardSuit(int number)
        {
            switch (number)
            {
                case 1:
                    return CardSuits.Spades;
                case 2:
                    return CardSuits.Clubs;
                case 3:
                    return CardSuits.Diamonds;
                default:
                    return CardSuits.Hearts;
            }

        }

        /// <summary>
        /// Console output for CardSuit option menu
        /// </summary>
        private void drawCardSuitOptions()
        {
            Console.Clear();
            Console.WriteLine("1. Spades");
            Console.WriteLine("2. Clubs");
            Console.WriteLine("3. Diamonds");
            Console.WriteLine("4. Hearts");
        }

        /// <summary>
        /// Search for a card in the deck
        /// </summary>
        private void cardSearch()
        {
            int number;
            CardSuits suit;
            int value;

            drawCardSuitOptions();
            Console.WriteLine("Enter the Card Suit:");
            string numberInput = Console.ReadLine();

            if (!int.TryParse(numberInput, out number))
            {
                Console.WriteLine("Invalid Number Type");
                return;
            }

            if (number > 0 && number < 5)
            {
                suit = getCardSuit(number);
                Console.WriteLine("Enter the Card Value (2-14 with Jack-Ace being 11 through 14):");
                numberInput = Console.ReadLine();
                if (!int.TryParse(numberInput, out value))
                {
                    Console.WriteLine("Invalid Number Type");
                    return;
                }

                if (deck.searchForCard(suit, value))
                {
                    Console.WriteLine("Card is still in the deck");
                }
                else
                { 
                    Console.WriteLine("Card is not in the Deck");
                }
            }
            else
            {
                Console.WriteLine("Invalid response, the card is not in the deck");
            }
        }
    }
}
