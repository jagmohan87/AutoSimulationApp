using AutoSimulationApp.CarPosition;
using AutoSimulationApp.Commands;

namespace AutoSimulationApp.Car
{
    /// <summary>
    /// Program to run command from user input
    /// </summary>
    public class AutoDrivingCar
    {
        // final position after calculation
        private Position currentPosition;

        /// <summary>
        /// Calculate exact position of Car
        /// </summary>
        /// <param name="initialPosition">Not Null</param>
        /// <param name="nextMove">Not Null</param>
        public AutoDrivingCar(Position initialPosition, string nextMove)
        {   
            CommandExecutor command = new CommandExecutor();
            currentPosition = command.ExecuteCommands(initialPosition, nextMove);
        }

        /// <summary>
        /// Return calculated final position of Car
        /// </summary>
        /// <returns></returns>
        public Position GetFinalPosition()
        {
            return currentPosition;
        }
    }
}
