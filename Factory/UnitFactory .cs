using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotFactory.Common;
using Common.Interfaces;
using BotFactory.Common.Tools;

namespace Factory
{
    public class UnitFactory : IUnitFactory
    {
        public int QueueCapacity { get; set; }

        public int StorageCapacity { get; set; }

        public Queue<FactoryQueueElement> FactoryQueue { get; set; }

       public List<ITestingUnit> Storage { get; set; }

        public UnitFactory(int queuecapacity , int storagecapacity)
        {
            this.FactoryQueue = new Queue<FactoryQueueElement>();
            this.QueueCapacity = queuecapacity;
            this.StorageCapacity = storagecapacity;
        }

        public bool AddWorkableUnitToQueue(string Name, Type Model, Coordinates WorkingPos , Coordinates ParkingPos)
        {
            Object lockThis = new Object();

            if (FactoryQueue.Count() > StorageCapacity || FactoryQueue.Count() > QueueCapacity)
            {
                return false;
            }

            lock (lockThis)
            {
              
                FactoryQueue.Enqueue(new FactoryQueueElement { Name = Name, Model = Model, WorkingPos = WorkingPos, ParkingPos = ParkingPos });
                return true;
            }
           

        }
    }


}
