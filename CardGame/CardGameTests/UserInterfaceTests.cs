using CardGame;
using Xunit;

namespace CardGameTests
{
    public class UserInterfaceTests
    {
        [Fact]
        public void TestMenuFunction()
        {
            UserInterface app = new UserInterface();
            {
                try
                {
                    app.startMenu();
                    Assert.True(true);
                }
                catch
                {
                    Assert.True(false);
                }
            }
        }

        [Fact]
        public void TestContinuePromptFunction()
        {
            UserInterface app = new UserInterface();
            {
                try
                {
                    app.continuePrompt();
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
