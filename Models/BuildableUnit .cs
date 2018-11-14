using Common;
using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract class BuildableUnit : IBuildableUnit
    {

        public string Model { get; set; }
        public BuildableUnit(double TempsConstruction  )
        {
            this.BuildTime = TempsConstruction;

        }

        public BuildableUnit()
        {
            this.BuildTime = 5;

        }
        public double BuildTime { get; set; } 
    }

}
