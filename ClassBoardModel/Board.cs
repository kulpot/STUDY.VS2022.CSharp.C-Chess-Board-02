﻿using System;
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
        
        // constructor
        public Board(int s)
        {
            // initial size of the board is defined by parameter s.
            Size = s;

            // create a new 2D array of type cell.
            theGrid = new Cell[Size, Size];

            // fill the 2D array with new Cells, each with unique x and y coordinates.
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
