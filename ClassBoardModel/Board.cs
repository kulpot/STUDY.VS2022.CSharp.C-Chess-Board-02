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
        //---------END--------- C# Chess Board 02 board cell classes -------------------------------

    }
}
