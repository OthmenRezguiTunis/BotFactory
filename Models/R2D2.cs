using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class R2D2 : WorkingUnit
    {
        public readonly double _vitesse = 1.5;
        public readonly double _tempsconstruction = 5.5;

        public R2D2() : base(nameof(R2D2))
        {
            this.Speed = _vitesse;
            this.BuildTime = _tempsconstruction;

        }
    }
}
