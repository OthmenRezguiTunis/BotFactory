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




        public virtual async Task WorkBegins()
        {
            this.IsWorking = await this.Move(this.CurrentPos, this.WorkingPos);


        }


        public virtual async Task WorkEnds()
        {
            this.IsWorking = await this.Move(this.CurrentPos, this.ParkingPos);

        }
    }
}
