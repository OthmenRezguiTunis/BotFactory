using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Wall_E : WorkingUnit
    {
        public readonly double _vitesse = 2;
        public readonly double _tempsconstruction = 4;
    

        public Wall_E () : base(nameof(Wall_E))
        {
            this.Speed = _vitesse;
            this.BuildTime = _tempsconstruction;


        }
    }
}
