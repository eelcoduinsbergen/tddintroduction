using System.Data;

namespace TDDIntro.Kata.MarsRover
{


    public enum MoveDirection
    {
        Forward = 1, Backward = -1
    }    
    
    public class MarsRover
    {
        private readonly int GridWidth;
        private readonly int GridHeight;

        public Position Position { get; private set; }
        public Direction Direction { get; set; }

        public MarsRover(int positionX, int positionY, Direction direction, int gridWidth, int gridHeight)
        {
            this.Position = new Position(positionX, positionY);
            Direction = direction;
            this.GridWidth = gridWidth;
            this.GridHeight = gridHeight;
        }

        public void ExecuteCommand(string commands)
        {
            foreach(char command in commands.ToLower())
            {
                switch (command)
                {
                    case 'f':
                        Move(MoveDirection.Forward);
                        break;
                    case 'b':
                        Move(MoveDirection.Backward);
                        break;
                    case 'l':
                        Turn(TurnDirection.Left);
                        break;
                    case 'r':
                        Turn(TurnDirection.Right);
                        break;
                    default:
                        break;                            
                }
            }
        }

        private void Turn(TurnDirection direction)
        {
            Direction.Turn(direction);
        }

        private void Move(MoveDirection direction)
        {
            int newX = Position.x;
            int newY = Position.y;

            switch (Direction.Current)
            {
                case Directions.North:
                    newY = Position.y - (int)direction;
                    break;
                case Directions.South:
                    newY = Position.y + (int)direction;
                    break;
                case Directions.West:
                    newX = Position.x - (int)direction;
                    break;
                case Directions.East:
                    newX = Position.x + (int)direction;
                    break;
            }

            if(newX < 0)
            {
                newX = GridWidth - Math.Abs(newX);
            }
            
            if(newY < 0)
            {
                newY = GridHeight - Math.Abs(newY);
            }    

            Position = new Position(newX, newY);
        }
    }
}