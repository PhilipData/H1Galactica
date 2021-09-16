using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Galactica
{
    sealed class Moon : Planet
    {
        public Planet Orbiting { get; set; }
        public int Distance()//Polymorphism: Der eksistere allerede en metoden der hedder Distance men den har parametere
        {
            return (int)(Math.Sqrt(Math.Pow(this._Position.X - Orbiting._Position.X, 2)) + (Math.Pow(this._Position.Y - Orbiting._Position.Y, 2)));
        }
    }
}
