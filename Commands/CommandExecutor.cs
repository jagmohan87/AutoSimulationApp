using AutoSimulationApp.CarPosition;
using AutoSimulationApp.Enum;

namespace AutoSimulationApp.Commands
{
    /// <summary>
    /// Command to execute car movement
    /// </summary>
    public class CommandExecutor
    {
        // Current position of car
        private Position currentPosition;

        /// <summary>
        /// Move car as per given command
        /// </summary>
        /// <param name="initialPosition">X and Y position</param>
        /// <param name="commands">Not Null</param>
        /// <returns></returns>
        public Position ExecuteCommands(Position initialPosition, string commands)
        {
            currentPosition = initialPosition;
            foreach (char command in commands)
            {
                switch (command)
                {
                    case 'L':
                        RotateLeft();
                        break;
                    case 'R':
                        RotateRight();
                        break;
                    case 'F':
                        MoveForward();
                        break;
                    default:
                        // Ignore invalid commands
                        break;
                }
            }
            return currentPosition;
        }

        /// <summary>
        /// Rotate car to left side
        /// </summary>
        private void RotateLeft()
        {
            currentPosition.FacingDirection = (Direction)(((int)currentPosition.FacingDirection + 3) % 4);
        }

        /// <summary>
        /// Rotate car to right side
        /// </summary>
        private void RotateRight()
        {
            currentPosition.FacingDirection = (Direction)(((int)currentPosition.FacingDirection + 1) % 4);
        }

        /// <summary>
        /// Move car forward based on direction
        /// </summary>
        private void MoveForward()
        {
            switch (currentPosition.FacingDirection)
            {
                case Direction.N:
                    if (currentPosition.Y < Field.Field.Height - 1)
                        currentPosition.Y++;
                    break;
                case Direction.E:
                    if (currentPosition.X < Field.Field.Width - 1)
                        currentPosition.X++;
                    break;
                case Direction.S:
                    if (currentPosition.Y > 0)
                        currentPosition.Y--;
                    break;
                case Direction.W:
                    if (currentPosition.X > 0)
                        currentPosition.X--;
                    break;
            }
        }
    }
}
