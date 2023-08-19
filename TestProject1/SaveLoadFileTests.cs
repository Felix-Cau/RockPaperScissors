using Microsoft.VisualStudio.TestPlatform.Utilities;
using RockPaperScissors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TestProject1
{
    public class SaveLoadFileTests
    {
        [Fact]
        public void SaveGameFiles_AndCorrectDataIsWrittenTest()
        {
            //Arrange
            string fileName = "testSaveGame.json";
            string fileDirectory = @"C:\development\rockpaperscissors\data\";
            string path = Path.Combine(fileDirectory, fileName);

            //Act
            Utilities.SaveGame(fileName);

            //Assert
            var jsonGameResultWrittenData = File.ReadAllText(path);
            SaveFiles gameResultsWrittenData = JsonSerializer.Deserialize<SaveFiles>(jsonGameResultWrittenData);
            Assert.True((gameResultsWrittenData.userWin == GameResults.UserWin) && (gameResultsWrittenData.tie == GameResults.Tie) && (gameResultsWrittenData.computerWin == GameResults.ComputerWin));
        }

        [Fact]
        public void LoadGameFiles_AndCorrectDataIsLoadedTest()
        {
            //Arrange
            string fileName = "testSaveGame.json";
            string fileDirectory = @"C:\development\rockpaperscissors\data\";
            string path = Path.Combine(fileDirectory, fileName);

            //Act
            Utilities.LoadSaveGame(fileName);

            //Assert
            var jsonGameResultLoadedData = File.ReadAllText(path);
            SaveFiles gameResultsLoadedData = JsonSerializer.Deserialize<SaveFiles> (jsonGameResultLoadedData);
            Assert.True((gameResultsLoadedData.userWin == GameResults.UserWin) && (gameResultsLoadedData.tie == GameResults.Tie) && (gameResultsLoadedData.computerWin == GameResults.ComputerWin));
        }
    }
}
