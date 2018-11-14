﻿using BotFactory.Common.Tools;
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
            await Task.Run(() => Thread.Sleep(2000));
            this.CurrentPos.X = this.WorkingPos.X;
            this.CurrentPos.Y = this.WorkingPos.Y;


        }


        public virtual async Task WorkEnds()
        {
            await Task.Run(() => Thread.Sleep(2000));
            this.CurrentPos.X = this.ParkingPos.X;
            this.CurrentPos.Y = this.ParkingPos.Y;

        }
    }
}
