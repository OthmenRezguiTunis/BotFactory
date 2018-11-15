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
        private int QueueCapacity { get; set; }

        private int StorageCapacity { get; set; }

        public Queue<IFactoryQueueElement> FactoryQueue { get; set; }

       public List<ITestingUnit> Storage { get; set; }

        public UnitFactory(int queuecapacity , int storagecapacity)
        {
            this.FactoryQueue = new Queue<IFactoryQueueElement>();
            this.QueueCapacity = queuecapacity;
            this.StorageCapacity = storagecapacity;
        }

        public bool AddWorkableUnitToQueue(string Name, Type Model, Coordinates WorkingPos , Coordinates ParkingPos)
        {
            Object lockThis = new Object();

            if (Storage.Count() > StorageCapacity || FactoryQueue.Count() > QueueCapacity)
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
