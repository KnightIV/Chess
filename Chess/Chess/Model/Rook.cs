using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Model
{
    class Rook : Piece
    {
        private Coordinate[] threatVal;
        private Coordinate[] rangeOfMotion;
        private Coordinate initialPos;
        private int playerNum;

        public Coordinate[] ThreatVal { get; }
        public Coordinate[] RangeOfMotion { get; }
        public Coordinate InitialPos { get; }
        public int PlayerNum { get; }

        public Rook(Coordinate[] threat, Coordinate[] range, Coordinate startPos, int player)
        {
            this.threatVal = threat;
            this.rangeOfMotion = range;
            this.initialPos = startPos;
            this.playerNum = player;
        }
    }
}
