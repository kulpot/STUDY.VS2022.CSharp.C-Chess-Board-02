using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBoardModel
{
    class Board
    {
        //---------START--------- C# Chess Board 02 board cell classes -------------------------------
        // the size of the board usually 8x8
        public int Size { get; set; }

        // 2d array of type cell.
        public Cell[,] theGrid { get; set; }

        public Board(int s)
        {
            Size = s;

            theGrid = new Cell[Size, Size];

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    theGrid[i, j] = new Cell(i, j);
                }
            }
        }
        //---------END--------- C# Chess Board 02 board cell classes -------------------------------

    }
}
