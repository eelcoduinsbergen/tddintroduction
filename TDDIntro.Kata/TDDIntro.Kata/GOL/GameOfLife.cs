using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TDDIntro.Kata.GOL
{
    public class GameOfLife
    {
        public bool[,] Board { get; private set; }
        public GameOfLife(bool[,] board)
        {
            Board = board;
        }

        public void NextGen()
        {
            var maxRows = Board.GetUpperBound(0);
            var maxColumns = Board.GetUpperBound(1);
            bool[,] newBoard = new bool[3, 3];

            for (int row = 0; row <= maxRows; row++)
            {
                for(int column = 0; column <= maxColumns; column++)
                {
                    var numberOfAliveNeighbours = GetNumberOfAliveNeighbours(row, column);
                    newBoard[row, column] = CellIsAlive(Board[row,column], numberOfAliveNeighbours);
                }
            }

            Board = newBoard;
        }

        private static bool CellIsAlive(bool isAlive, int numberOfAliveNeighbours)
        {
            if(isAlive)
            {
                return numberOfAliveNeighbours == 2 || numberOfAliveNeighbours == 3;
            }
            return numberOfAliveNeighbours == 3;
        }

        private int GetNumberOfAliveNeighbours(int row, int column)
        {
           var neighbours = GetNeighbours(row, column);

            return neighbours.Where(p => p).Count();
        }

        private bool[] GetNeighbours(int row, int column)
        {
            List<bool> neighbours = new List<bool>();
     

            for(int boardRow = row - 1; boardRow <= row + 1; boardRow++)
            {
                if (RowIsInBounds(boardRow))
                    continue;

                for (int boardColumn = column - 1; boardColumn <= column + 1; boardColumn++)
                {
                    if (ColumnIsInBounds(boardColumn) || (boardRow == row && boardColumn == column))
                        continue;

                    neighbours.Add(Board[boardRow, boardColumn]);
                }
            }

            return neighbours.ToArray();
        }

        private bool ColumnIsInBounds(int boardColumn)
        {
            return boardColumn < 0 || boardColumn > Board.GetUpperBound(1);
        }

        private bool RowIsInBounds(int row)
        {
            return row < 0 || row > Board.GetUpperBound(0);
        }
    }
}
