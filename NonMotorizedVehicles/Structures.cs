using Enumerations;
using INonMotorizedVehicles;

namespace Structures
{
    public struct Tricycle : INonMotorizedVehicle
    {
         private bool isMoving;
        public TerrainType TerrainType { get; set; }
        public int NoOfWheels { get; set; }
        public string Brakes { get; set; }
        public bool HasPedals { get; set; }
        public bool Moving()
        {
            return this.isMoving;
        }
        public bool Moving(bool isMoving)
        {
            this.isMoving = isMoving;
            return this.isMoving;
        }
    }
}
