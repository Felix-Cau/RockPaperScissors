using RockPaperScissors;

namespace TestProject1
{
    public class EventResolutionTests
    {
        [Fact]
        public void Tie()
        {
            //Arrange
            Entities a = new();
            a.Entity = "Rock";
            
            Entities b = new();
            b.Entity = "Rock";

            Entities resolution = new();

            //Act
            resolution.Resolution = EventResolutions.CalculateResolution(a.Entity, b.Entity);

            //Assert
            Assert.Matches("Tie", resolution.Resolution);
        }

        [Fact]
        public void Win()
        {
            //Arrange
            Entities a = new();
            a.Entity = "Paper";

            Entities b = new();
            b.Entity = "Rock";

            Entities resolution = new();

            //Act
            resolution.Resolution = EventResolutions.CalculateResolution(a.Entity, b.Entity);

            //Assert
            Assert.Matches("Win", resolution.Resolution);
        }

        [Fact]
        public void Loss()
        {
            Entities a = new();
            a.Entity = "Rock";

            Entities b = new();
            b.Entity = "Paper";

            Entities resolution = new();

            //Act
            resolution.Resolution = EventResolutions.CalculateResolution(a.Entity, b.Entity);

            //Assert
            Assert.Matches("Loss", resolution.Resolution);
        }
    }
}