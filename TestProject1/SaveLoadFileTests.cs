using Microsoft.VisualStudio.TestPlatform.Utilities;
using RockPaperScissors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class SaveLoadFileTests
    {
        [Fact]
        public void SaveGameFileTest()
        {
            //Arrange
            string fileName = "testSaveGame.txt";
            string directory = @"C:\development\rockpaperscissors\data\";

            string path = Path.Combine(directory, fileName);

            //Act
            Utilities.SaveGame(fileName);
            bool existingFileFound = File.Exists(path);

            //Assert
            Assert.True(existingFileFound);
        }

        public void LoadGameFileTest()
        {
            //Arrange

            //Act

            //Assert
        }
    }
}
