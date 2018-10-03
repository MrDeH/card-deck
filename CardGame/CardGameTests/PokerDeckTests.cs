using CardGame;
using Xunit;

namespace CardGameTests
{
    public class PokerDeckTests
    {
        [Fact]
        public void TestDeckBuild()
        {
            PokerDeck deck = new PokerDeck();
            Assert.Equal(52,deck.getCount());
        }

        [Fact]
        public void TestGetCards()
        {
            PokerDeck deck = new PokerDeck();
            deck.makeHandOfCards(4);
            Assert.Equal(48, deck.getCount());
        }

        [Fact]
        public void TestGetCard()
        {
            PokerDeck deck = new PokerDeck();
            deck.getCard();
            Assert.Equal(51, deck.getCount());
        }

        [Fact]
        public void TestDisplayAllCardsDoesntChangeCount()
        {
            PokerDeck deck = new PokerDeck();
            deck.displayCardsInDeck();
            Assert.Equal(52, deck.getCount());
        }

        [Fact]
        public void TestDisplayCardsDoesntChangeCount()
        {
            //Overloaded function test
            PokerDeck deck = new PokerDeck();
            deck.displayCardsInDeck(4);
            Assert.Equal(52, deck.getCount());
        }

        [Fact]
        public void TestShuffle() {
            /*can't test object directly as there is a
            * chance it might be the same after a sort.
            * So test that the method runs
            */
            PokerDeck deck = new PokerDeck();
            {
                try
                {
                    deck.shuffle();
                    Assert.True(true);
                }
                catch
                {
                    Assert.True(false);
                }
            }
        }

        [Fact]
        public void TestCountCardsLeftInDeck()
        {
            PokerDeck deck = new PokerDeck();
            {
                try
                {
                    deck.countCardsLeftInDeck();
                    Assert.True(true);
                }
                catch
                {
                    Assert.True(false);
                }
            }
        }

    }
}
