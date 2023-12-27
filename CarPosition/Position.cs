using AutoSimulationApp.Enum;

namespace AutoSimulationApp.CarPosition
{
    /// <summary>
    /// Defines car position and direction of car pointing to
    /// </summary>
    public class Position
    {
        /// <summary>
        /// X axis i.e West or East
        /// </summary>
        public int X { get; set; }
        /// <summary>
        /// Y axis i.e North of South
        /// </summary>
        public int Y { get; set; }
        /// <summary>
        /// Directing of car pointing to
        /// </summary>
        public Direction FacingDirection { get; set; }
    }
}
