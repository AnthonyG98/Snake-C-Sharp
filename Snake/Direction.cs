using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Snake
{
    public class Direction
    {

        public readonly static Direction Left = new Direction(0, -1);
        public readonly static Direction Right = new Direction(0, 1);
        public readonly static Direction Up = new Direction(-1, 0);
        public readonly static Direction Down = new Direction(1, 0);


        public int RowOffset { get; }
        public int ColOffset { get; }

        private Direction(int rowOffset, int colOffset)
        {
            //BC the contructor is private no other class can create an instance
            //of the direction class
            RowOffset = rowOffset;
            ColOffset = colOffset;
        }

        public Direction Opposite()
        {
            return new Direction(-RowOffset, -ColOffset);
        }

        public override bool Equals(object obj)
        {
            return obj is Direction direction &&
                   RowOffset == direction.RowOffset &&
                   ColOffset == direction.ColOffset;
        }
        //takes "ColOffset" and "RowOffset" and stores a unique value in a data structure
        //for the game to refer to in an instant
        public override int GetHashCode()
        {
            return HashCode.Combine(RowOffset, ColOffset);
        }
        public static bool operator ==(Direction left, Direction right)
        {
            return EqualityComparer<Direction>.Default.Equals(left, right);
        }

        public static bool operator !=(Direction left, Direction right)
        {
            return !(left == right);
        }
    }
}
