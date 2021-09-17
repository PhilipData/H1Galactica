using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Galactica
{
    enum PlanetType { Terrestial, Giant, Dwarf, Gas_Giant }
    class Planet : SpaceObjects
    {
        public int Diameter_I_M { get; set; }
        public int RoationsPeriod_I_Timer { get; set; }
        public int RevolutionsPeriode_I_Dage { get; set; }
        public PlanetType _PlanetType { get; set; }
        public List<Moon> _Moon = new List<Moon>();

        public int Distance(Star star)
        {
            return (int)(Math.Sqrt(Math.Pow(this._Position.X-star._Position.X,2)) + (Math.Pow(this._Position.Y - star._Position.Y,2)));
        }
    }
}
