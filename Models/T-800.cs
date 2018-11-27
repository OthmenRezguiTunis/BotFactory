using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class T_800 : WorkingUnit , ITestingUnit
    {
        public readonly double _vitesse = 3;
        public readonly double _tempsconstruction = 10;

        public T_800() : base(nameof(T_800))
        {
            this.Speed = _vitesse;
            this.BuildTime = _tempsconstruction;

        }

    }
}
