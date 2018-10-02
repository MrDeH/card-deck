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
        public void TestDisplayCardsDoesntChangeCount()
        {
            PokerDeck deck = new PokerDeck();
            deck.displayCardsInDeck(4);
            Assert.Equal(52, deck.getCount());
        }
    }
}
