using Enumerations;

namespace Structures
{
    public struct Tricycle : INonMotorizedVehicle
    {
        public TerrainType TerrainType { get; set; }
        public int NoOfTires { get; set; }
        public string Brakes { get; set; }
        

    }
}
