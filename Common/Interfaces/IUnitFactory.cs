using System;
using System.Collections.Generic;
using BotFactory.Common.Tools;
using Common.Interfaces;

namespace Factory
{
    public interface IUnitFactory
    {
        Queue<IFactoryQueueElement> FactoryQueue { get; set; }
        int QueueCapacity { get; set; }
        List<ITestingUnit> Storage { get; set; }
        int StorageCapacity { get; set; }

        bool AddWorkableUnitToQueue(string Name, Type Model, Coordinates WorkingPos, Coordinates ParkingPos);
    }
}