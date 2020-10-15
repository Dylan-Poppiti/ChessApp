using System;
using System.Collections.Generic;
using System.Text;

namespace ChessApp
{
    class Piece
    {
        public bool isPlayer1 { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }
        public string Rep { get; set; }
        public void Move(){}
        public Piece(Piece[,] p){
        }
        public string toString()
        {
            return Rep;
        }
    }
}
