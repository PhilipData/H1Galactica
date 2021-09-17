using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Galactica
{
    
    abstract class SpaceObjects
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Position _Position { get; set; }
        
        
        internal class Position
        {
            public int Y { get; set; }
            public int X { get; set; }

            public override string ToString()
            {
                return $"({X},{Y})";
            }
        }
    }

}
