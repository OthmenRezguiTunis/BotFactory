using System;
using System.Collections.Generic;
using BotFactory.Common.Tools;
using Common.Interfaces;

namespace Common.Interfaces
{
    public interface IUnitFactory
    {
        Queue<IFactoryQueueElement> Queue { get; set; }
     
        List<ITestingUnit> Storage { get; set; }

         int QueueCapacity { get; set; }

         int StorageCapacity { get; set; }


        int QueueFreeSlots { get; }


        int StorageFreeSlots { get;}





        TimeSpan QueueTime { get; set; }
        Action<object, EventArgs> FactoryStatus { get; set; }

        bool AddWorkableUnitToQueue(string Name, Type Model, Coordinates WorkingPos, Coordinates ParkingPos);
    }
}