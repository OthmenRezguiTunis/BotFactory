using BotFactory.Common.Tools;
using BotFactory.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Common;
using Common.Interfaces;

namespace Models
{
   public abstract class BaseUnit : BuildableUnit, IBaseUnit
    {
        public double Speed { get; set; }

        public string Name { get; set; }

        public Coordinates CurrentPos { get; set; }

        public BaseUnit(string Name) 
        {
            this.Name = Name;
        }
        public BaseUnit( string Name, double buildtime, double Speed = 1) : base(buildtime)
        {
            this.Speed = Speed;
            this.Name = Name;
            this.CurrentPos = new Coordinates { X = 1, Y = 1 };
        }


        public async Task Move (double x , double y )
        {

            int temps = (int)(Math.Abs(x - y) / this.Speed);
            Thread.Sleep(temps);
            this.CurrentPos.X = x;
            this.CurrentPos.X = y;


        }

    }
}
