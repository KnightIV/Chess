using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Model
{
    public class Piece
    {
        private Coordinate currentPosition;
        private bool wasMoved;
        private Coordinate[] threat;
        private Coordinate[] rangeOfMotion;
        private int playerNumber;

        public Coordinate CurrentPosition
        {
            get { return currentPosition; }
            set { currentPosition = value; }
        }
        
        public bool WasMoved
        {
            get { return wasMoved; }
            set { wasMoved = value; }
        }
        
        public Coordinate[] Threat
        {
            get { return threat; }
            set { threat = value; }
        }
        
        public Coordinate[] RangeOfMotion
        {
            get { return rangeOfMotion; }
            set { rangeOfMotion = value; }
        }
        
        public int PlayerNumber
        {
            get { return playerNumber; }
            set { playerNumber = value; }
        }

        public Piece(int playerNumber)
        {
			PlayerNumber = playerNumber;
        }

    }
}
