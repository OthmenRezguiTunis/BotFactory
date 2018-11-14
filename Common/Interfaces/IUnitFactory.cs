using System;
using System.Collections.Generic;
using BotFactory.Common.Tools;
using Common.Interfaces;

namespace Factory
{
    public interface IUnitFactory
    {
        Queue<IFactoryQueueElement> FactoryQueue { get; set; }
     
        List<ITestingUnit> Storage { get; set; }
     

        bool AddWorkableUnitToQueue(string Name, Type Model, Coordinates WorkingPos, Coordinates ParkingPos);
    }
}