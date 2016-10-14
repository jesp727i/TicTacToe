using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Services
{


    public class GameWinnerService : IGameWinnerService
    {
        private const char SymbolForNoWinner = ' ';
        private char cellOneChar;
        private char cellTwoChar;
        private char cellThreeChar;
        private char cellFourChar;
        private char cellFiveChar;
        private char cellSixChar;
        private char cellSevenChar;
        private char cellEightChar;
        private char cellNineChar;
        public char Validate(char[,] gameBoard)
        {
            setCells(gameBoard);
            
            var currentWinningSymbol = CheckForThreeInARowInHorizontalRow();
            if (currentWinningSymbol != SymbolForNoWinner) return currentWinningSymbol;
            currentWinningSymbol = CheckForThreeInARowInVerticalColumn();
            if (currentWinningSymbol != SymbolForNoWinner) return currentWinningSymbol;
            currentWinningSymbol = CheckForThreeInARowDiagonally();
            return currentWinningSymbol;
            
        }
        private char CheckForThreeInARowInVerticalColumn()
        {

            if (cellOneChar == cellFourChar && cellFourChar == cellSevenChar && cellOneChar != ' ')
            {
                return cellOneChar;
            }
            else if (cellTwoChar == cellFiveChar && cellFiveChar == cellEightChar && cellTwoChar != ' ')
            {
                return cellTwoChar;
            }
            else if (cellThreeChar == cellSixChar && cellSixChar == cellNineChar && cellThreeChar != ' ')
            {
                return cellThreeChar;
            }
            else
            {
                return SymbolForNoWinner;
            }
        }
        private char CheckForThreeInARowDiagonally()
        {

            if (cellOneChar == cellFiveChar && cellFiveChar == cellNineChar && cellOneChar != ' ')
            {
                return cellOneChar;
            }
            else if (cellThreeChar == cellFiveChar && cellFiveChar == cellSevenChar && cellThreeChar != ' ')
            {
                return cellThreeChar;
            }
            else
            {
                return SymbolForNoWinner;
            }
        }
        private char CheckForThreeInARowInHorizontalRow()
        {

            if (cellOneChar == cellTwoChar && cellTwoChar == cellThreeChar && cellOneChar != ' ')
            {
                return cellOneChar;
            }
            else if (cellFourChar == cellFiveChar && cellFiveChar == cellSixChar && cellFourChar != ' ')
            {
                return cellFourChar;
            }
            else if (cellSevenChar == cellEightChar && cellEightChar == cellNineChar && cellSevenChar != ' ')
            {
                return cellSevenChar;
            }
            else
            {
                return SymbolForNoWinner;
            }
        }
        private void setCells(char[,] gameBoard)
        {
            cellOneChar = gameBoard[0, 0];
            cellTwoChar = gameBoard[0, 1];
            cellThreeChar = gameBoard[0, 2];
            cellFourChar = gameBoard[1, 0];
            cellFiveChar = gameBoard[1, 1];
            cellSixChar = gameBoard[1, 2];
            cellSevenChar = gameBoard[2, 0];
            cellEightChar = gameBoard[2, 1];
            cellNineChar = gameBoard[2, 2];
        }

    }
}
