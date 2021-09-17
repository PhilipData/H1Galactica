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

        public List<Planet> planets = new List<Planet>();

        new public Position Position { get; }
        public Star()
        {
            this.Position = new Position() { X = 0, Y = 0 };
            planets = new List<Planet>();
        }

        //public new Position _Position
        //{
        //    //get;
        //    get { return new Position() { X = 0, Y = 0 }; }
        //    //set { }
        //}

    }
}
