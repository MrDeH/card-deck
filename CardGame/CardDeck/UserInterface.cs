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

        private void menuOption()
        {
            int value;
            string input = Console.ReadLine();
            if (!int.TryParse(input, out value))
            {
                Console.WriteLine("Invalid Number Type");
            }
            else
            {
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
            }
            if (!quitFlag)
            {
                continuePrompt();
                Console.Clear();
                startMenu();
            }
        }

        private bool checkDeck()
        {
            return deck != null && deck.getCount() > 0;
        }

        public void continuePrompt(){
            Console.WriteLine(Environment.NewLine + "Press any key to continue...");
            Console.ReadKey();
        }

        private void deckBuiltMessage()
        {
            deck.countCardsLeftInDeck();
        }

        private void quit()
        {
            quitFlag = true;
        }

        private int promptNumber() {
            int number = 0;

            Console.WriteLine("How many cards would you like? ");

            string numberInput = Console.ReadLine();

            if (!int.TryParse(numberInput, out number))
            {
                Console.WriteLine("Invalid Number Type");
            }
            else
            {
                if (number < 1)
                {
                    Console.WriteLine("Number has to be greater than 0");
                }
                else
                {
                    return number;
                }
            }
            return -1;
        }

        private void getCards()
        {
            int value = promptNumber();
            if(value != -1)
            {
                deck.makeHandOfCards(value);
            }
        }

        private void displayCards()
        {
            int value = promptNumber();
            if (value != -1)
            {
                deck.displayCardsInDeck(value);
            }
        }

        private CardSuits getCardSuit(int number)
        {
            switch (number)
            {
                case 1:
                    return CardSuits.Spades;
                case 2:
                    return CardSuits.Spades;
                case 3:
                    return CardSuits.Diamonds;
                default:
                    return CardSuits.Hearts;
            }

        }


        private void drawCardSuitOptions()
        {
            Console.Clear();
            Console.WriteLine("1. Spades");
            Console.WriteLine("2. Clubs");
            Console.WriteLine("3. Diamonds");
            Console.WriteLine("4. Hearts");
        }

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
            }
            else
            {
                if (number > 0 && number < 5)
                {
                    suit = getCardSuit(number);
                    Console.WriteLine("Enter the Card Value (2-14 with Jack-Ace being 11 through 14):");
                    numberInput = Console.ReadLine();
                    if (!int.TryParse(numberInput, out value))
                    {
                        Console.WriteLine("Invalid Number Type");
                    }
                    else
                    {
                        if (deck.searchForCard(suit, value))
                        {
                            Console.WriteLine("Card is still in the deck");
                        }
                        else
                        { 
                            Console.WriteLine("Card is not in the Deck");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid response, the card is not in the deck");
                }
            }
        }
    }
}
