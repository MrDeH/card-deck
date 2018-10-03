using System;

namespace CardGame
{
    class UserInterface
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
                Console.WriteLine("7. Quit" + Environment.NewLine);
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

        private void continuePrompt(){
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
    }
}
