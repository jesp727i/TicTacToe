using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Services;

namespace TicTacToe.UnitTests
{
    [TestFixture]
    public class GameWinnerServiceTests
    {
        private GameWinnerService _gameWinnerService;
        private char[,] _gameBoard;
        private int Teller;
        const char expected = 'X';
        [SetUp]
        public void SetupUnitTests() {
            _gameWinnerService = new GameWinnerService();
            _gameBoard = new char[3, 3] {
                    {' ', ' ', ' '},
                    {' ', ' ', ' '},
                    {' ', ' ', ' '}
                };
        }
        [Test]
        public void NeitherPlayerHasThreeInARow()
        {

            const char expected = ' ';
            var actual = _gameWinnerService.Validate(_gameBoard);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void PlayerWithAllSpacesInTopRowIsWinner()
        {
            IGameWinnerService gameWinnerService;
            gameWinnerService = new GameWinnerService();
            var gameBoard = new char[3, 3] {
                    { expected, expected, expected},
                    {' ', ' ', ' '},
                    {' ', ' ', ' '}
                };
            var actual = gameWinnerService.Validate(gameBoard);
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
        [Test]
        public void PlayerWithAllSpacesInMiddelRowIsWinner()
        {
            IGameWinnerService gameWinnerService;
            gameWinnerService = new GameWinnerService();
            var gameBoard = new char[3, 3] {
                    {' ', ' ', ' '},
                    {expected, expected, expected},
                    {' ', ' ', ' '}
                };
            var actual = gameWinnerService.Validate(gameBoard);
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
        [Test]
        public void PlayerWithAllSpacesInBottomRowIsWinner()
        {
            IGameWinnerService gameWinnerService;
            gameWinnerService = new GameWinnerService();
            var gameBoard = new char[3, 3] {
                    {' ', ' ', ' '},
                    {' ', ' ', ' '},
                    { expected, expected, expected }
                };
            var actual = gameWinnerService.Validate(gameBoard);
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
        [Test]
        public void PlayerWithAllSpacesInFirstColumnIsWinner()
        {
            for (var columnIndex = 0; columnIndex < 3; columnIndex++)
            {
                _gameBoard[columnIndex, 0] = expected;
            } var actual = _gameWinnerService.Validate(_gameBoard);
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
        [Test]
        public void PlayerWithAllSpacesInSecondColumnIsWinner()
        {
            for (var columnIndex = 0; columnIndex < 3; columnIndex++)
            {
                _gameBoard[columnIndex, 1] = expected;
            }
            var actual = _gameWinnerService.Validate(_gameBoard);
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
        [Test]
        public void PlayerWithAllSpacesInThirdColumnIsWinner()
        {
            for (var columnIndex = 0; columnIndex < 3; columnIndex++)
            {
                _gameBoard[columnIndex, 2] = expected;
            }
            var actual = _gameWinnerService.Validate(_gameBoard);
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
        [Test]
        public void PlayerWithThreeInARowDiagonallyDownAndToRightIsWinner()
        {
            for (var cellIndex = 0; cellIndex < 3; cellIndex++)
            {
                _gameBoard[cellIndex, cellIndex] = expected;
            } var actual = _gameWinnerService.Validate(_gameBoard);
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
        [Test]
        public void PlayerWithThreeInARowDiagonallyDownAndToLftIsWinner()
        {
            Teller = 2;
            for (var cellIndex = 0; cellIndex < 3; cellIndex++)
            {
                _gameBoard[cellIndex, Teller - cellIndex] = expected;

            }
            var actual = _gameWinnerService.Validate(_gameBoard);
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

    }

}
