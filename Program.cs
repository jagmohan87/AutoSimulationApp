using AutoSimulationApp.Car;
using AutoSimulationApp.CarPosition;
using AutoSimulationApp.Enum;
using AutoSimulationApp.Field;

namespace AutoDrivingCarSimulation
{
    class Program
    {
        /// <summary>
        /// Program to start
        /// </summary>
        /// <exception cref="Exception"></exception>
        static void Main()
        {
            //Read user input
            Console.WriteLine("Enter Width and Height");
            string start = Console.ReadLine();

            Console.WriteLine("Enter current position and facing direction");
            string currentPosition = Console.ReadLine();

            Console.WriteLine("Enter command");
            string nextMove = Console.ReadLine();   

            //validate command 
            if (!IsCommandValid(start, currentPosition, nextMove))
            {
                Console.WriteLine("Invalid input!");
                return;
            }

            // Set field dimensions
            string[] dimensions = start.Split(' ');
            Field.Width = int.Parse(dimensions[0]);
            Field.Height = int.Parse(dimensions[1]);

            // Set initial car position
            string[] initialPositionData = currentPosition.Split(' ');
            Position initialPosition = new Position
            {
                X = int.Parse(initialPositionData[0]),
                Y = int.Parse(initialPositionData[1]),
                FacingDirection = (Direction)Enum.Parse(typeof(Direction), initialPositionData[2])
            };

            // Create car and run the simulation
            AutoDrivingCar vento = new AutoDrivingCar(initialPosition, nextMove);
           
            // Get and print the final position
            Position finalPosition = vento.GetFinalPosition();
            Console.WriteLine($"{finalPosition.X} {finalPosition.Y} {finalPosition.FacingDirection.ToString()[0]}");
        }

        /// <summary>
        /// Null check validation for user input
        /// </summary>
        /// <param name="start">Not null</param>
        /// <param name="currentPosition">Not null</param>
        /// <param name="nextMove">Not null</param>
        /// <returns></returns>
        private static bool IsCommandValid(string start, string currentPosition, string nextMove)
        {
            //check null or empty user input
            if (string.IsNullOrWhiteSpace(start) ||
                string.IsNullOrWhiteSpace(currentPosition) ||
                string.IsNullOrWhiteSpace(nextMove))
            {
                return false;
            }
            return true;
        }
    }
}
