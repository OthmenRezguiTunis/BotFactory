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
   public abstract class BaseUnit : ReportingUnit, IBaseUnit
    {
        public double Speed { get; set; }

        public string Name { get; set; }

        public Coordinates CurrentPos { get; set; }

        public BaseUnit(string Name, double Speed = 1) 
        {
            this.Speed = Speed;
            this.Name = Name;
        }
        public BaseUnit( string Name, double buildtime, double Speed = 1) : base(buildtime)
        {
            this.Speed = Speed;
            this.Name = Name;
            this.CurrentPos = new Coordinates { X = 1, Y = 1 };
        }


        public async Task<bool> Move(Coordinates beginpos , Coordinates endpos )
        {
            if (endpos.Equals(beginpos))
            {
                var vect = Vector.FromCoordinates(beginpos, endpos);
                int temps = (int)(vect.Length() / this.Speed);
                await Task.Run(() => Thread.Sleep(temps));
                this.CurrentPos.X = endpos.X;
                this.CurrentPos.X = endpos.Y;
                return true;
            }

            else
            {
                return false;
            }


        }

    }
}
