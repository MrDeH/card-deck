using CardGame;
using Xunit;

namespace CardGameTests
{
    public class CardTests
    {
        [Fact]
        public void TestCardSuit()
        {
            Card card = new Card(CardSuits.Spades, 14);
            Assert.Equal(CardSuits.Spades, card.Suit);
        }

        [Fact]
        public void TestCardValue()
        {
            Card card = new Card(CardSuits.Spades, 14);
            Assert.Equal(14, card.Value);
        }

        [Fact]
        public void TestCardToString()
        {
            Card card = new Card(CardSuits.Spades, 14);
            Assert.Equal("Ace of Spades", card.ToString());
        }

    }
}

