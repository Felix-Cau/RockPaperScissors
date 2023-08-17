using Microsoft.VisualStudio.TestPlatform.Utilities;
using RockPaperScissors;

namespace TestProject1
{
    public class EventResolutionTests
    {
        [Fact]
        public void Tie()
        {
            //Arrange
            string a = "Rock";

            string b = "Rock";

            Entities resolution = new();

            //Act
            resolution.Resolution = EventResolutions.CalculateResolution(a, b);

            //Assert
            Assert.Matches("Tie", resolution.Resolution);
        }

        [Fact]
        public void Win()
        {
            //Arrange
            string a = "paper";

            string b = "Rock";

            Entities resolution = new();

            //Act
            resolution.Resolution = EventResolutions.CalculateResolution(a, b);

            //Assert
            Assert.Matches("Win", resolution.Resolution);
        }

        [Fact]
        public void Loss()
        {
            string a = "Rock";

            string b = "Paper";

            Entities resolution = new();

            //Act
            resolution.Resolution = EventResolutions.CalculateResolution(a, b);

            //Assert
            Assert.Matches("Loss", resolution.Resolution);
        }
    }
}