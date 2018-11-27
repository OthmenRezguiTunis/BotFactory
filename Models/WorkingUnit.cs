using BotFactory.Common.Tools;
using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Models
{
    public abstract class WorkingUnit : BaseUnit, IWorkingUnit
    {

        public Coordinates ParkingPos { get; set; }

        public Coordinates WorkingPos { get; set; }

        public bool IsWorking { get; set; }
        public WorkingUnit(string Name) : base(Name)
        {
           
        }




        public virtual async Task<bool> WorkBegins()
        {
            var result = await this.Move(this.CurrentPos, this.WorkingPos);
            this.OnStatusChanged(new StatusChangedEventArgs("I'm Working"));
            this.CurrentPos.X = this.WorkingPos.X;
            this.CurrentPos.Y = this.WorkingPos.Y;
            this.IsWorking = true;
            return result; 



        }


        public virtual async Task<bool> WorkEnds()
        {
            var result = await this.Move(this.CurrentPos, this.WorkingPos);
            this.OnStatusChanged(new StatusChangedEventArgs("I'm taking a break"));
            this.CurrentPos.X = this.ParkingPos.X;
            this.CurrentPos.Y = this.ParkingPos.Y;
            this.IsWorking = false;
            return result;

        }
    }
}
