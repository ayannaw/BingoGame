using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectI_Woodlin.Classes;

/**
 * Ayanna Woodlin
 * Frank Friedman
 * Project 1: Bingo
 * 1/24/2019
 * */

namespace ProjectI_Woodlin.Classes
{
    class InternalCard
    {
        private Boolean[,] card;
        private const int SIZE = 5;
        private string BingoLetters = "BINGO";
        public InternalCard()
        {
            card = new Boolean[SIZE, SIZE];
            for (int row = 0; row < SIZE; row++)
            {
                for (int col = 0; col < SIZE; col++)
                {
                    if (row == SIZE / 2 && col == SIZE / 2)
                    {
                        card[row, col] = true;
                    }
                    else
                    {
                        card[row, col] = false;
                    }
                }
            }
        }   //end constructor

        public void recordCalledNumber(int rowID, int colID)
        {
            card[rowID, colID] = true;
        }

        //Checks to see if there is bingo in any of the columns, rows, left or right diagonals.
        public Boolean isBingo()
        {
            Boolean isWinner = false;
            int rowBingoCounter = 0;
            int colBingoCounter = 0;
            Boolean rowBingo = false;
            Boolean colBingo = false;
            Boolean leftDiagBingo = false;
            Boolean rightDiagBingo = false;
            for (int x = 0; x < SIZE; x++)
            {
                if (checkRows(x) == true)
                {
                    rowBingoCounter++;
                }
                if (checkCols(x) == true)
                {
                    colBingoCounter++;
                }
            }
            if (rowBingoCounter > 0)
            {
                rowBingo = true;
            }
            if (colBingoCounter > 0)
            {
                colBingo = true;
            }
            leftDiagBingo = checkLeftDiag();
            rightDiagBingo = checkRightDiag();
            if (rowBingo == true || colBingo == true || leftDiagBingo == true || rightDiagBingo == true)
            {
                isWinner = true;
            }
            return isWinner;
        }   //end isBingo()
        //checks a certain row for BINGO
        private Boolean checkRows(int row)
        {
            int counter = 0;
            Boolean isBingoInRow = false;
            for (int col = 0; col < SIZE; col++)
            {
                if (card[row, col] == true)
                {
                    counter++;
                }
            }
            if (counter == 5)
            {
                isBingoInRow = true;
            }
            else
            {
                isBingoInRow = false;
            }
            return isBingoInRow;
        }
        //checks a certain col for BINGO
        private Boolean checkCols(int col)
        {
            int counter = 0;
            Boolean isBingoInCol = false;
            for (int row = 0; row < SIZE; row++)
            {
                if (card[row,col] == true)
                {
                    counter++;
                }
            }
            if (counter == 5)
            {
                isBingoInCol = true;
            }
            else
            {
                isBingoInCol = false;
            }

            return isBingoInCol;
        }
        //checks the left diagonal for BINGO
        private Boolean checkLeftDiag()
        {
            int counter = 0;
            Boolean isLeftBingo = false;
            for (int row = 0; row < SIZE; row++)
            {
                for (int col = 0; col < SIZE; col++)
                {
                    if (row == col)
                    {
                        if (card[row,col] == true)
                        {
                            counter++;
                        }
                    }
                }
            }
            if (counter == 5)
            {
                isLeftBingo = true;
            }
            else
            {
                isLeftBingo = false;
            }
            return isLeftBingo;
        }   //end checkLeftDiag()
        //checks right diagonal for BINGO
        private Boolean checkRightDiag()
        {
            int counter = 0;
            Boolean isRightBingo = false;
           /* for (int row = 0; row < SIZE; row++)
            {
                for (int col = SIZE - 1; col >= 0; col--)
                {
                    if (card[row, col] == true)
                    {
                        counter++;
                    }
                }
            }
            if (counter == 5)
            {
                isRightBingo = true;
            }
            else
            {
                isRightBingo = false;
            } */
            for (int row = 0; row < SIZE - 3; row++)
            {
                for (int col = 0; col < SIZE-3; col++)
                {
                    if (card[row,col] == true)
                    {
                        counter++;
                    }
                }
            }
            if (counter == 5)
            {
                isRightBingo = true;
            }
            else
            {
                isRightBingo = false;
            }
            return isRightBingo;
        }
    }   //end class
}   //end namespace
