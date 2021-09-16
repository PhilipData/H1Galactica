using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Galactica
{
    
    enum Startype { YellowDwarf, White, BlueNeutron, RedGiant }
    class Star : SpaceObjects
    {
        public Startype _Startype { get; set; }
        public int Temperature { get; set; }

        List<Planet> planets = new List<Planet>();
    }
}
