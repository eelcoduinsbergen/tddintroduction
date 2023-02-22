namespace TDDIntro.Kata.MarsRover
{
    public enum Directions
    {
        North = 0,
        East = 1,
        South = 2,
        West = 3
    }

    public enum TurnDirection
    {
        Left, Right
    }

    public class Direction
    {

        private Directions[] directions = new Directions[] { Directions.North, Directions.East, Directions.South, Directions.West };
        public Directions Current { get; private set; }

        public Direction(Directions direction)
        {
            Current = direction;
        }

        public void Turn(TurnDirection turnDirection)
        {
            var nextIndex = (turnDirection == TurnDirection.Left ? (int)Current - 1 : (int)Current + 1) % 4;

            if (nextIndex < 0)
            {
                nextIndex = 4 - Math.Abs(nextIndex);
            }

            Current = directions[nextIndex];
        }
    }
}
