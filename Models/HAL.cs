using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class HAL : WorkingUnit
    {
        public readonly double _vitesse = 0.5;
        public readonly double _tempsconstruction = 7;

        public HAL() : base(nameof(HAL))
        {
            this.Speed = _vitesse;
            this.BuildTime = _tempsconstruction;


        }
    }
}
