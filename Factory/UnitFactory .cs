using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotFactory.Common;
using Common.Interfaces;
using BotFactory.Common.Tools;

namespace Factories
{
    public class UnitFactory : IUnitFactory
    {
        public int QueueCapacity { get; set; }

        public int StorageCapacity { get; set; }

        public int  QueueFreeSlots
        {
            get
            {
                return   StorageCapacity - Storage.Count(); 
            } 

            set
            {

            }

        }

        public int StorageFreeSlots
        {
            get
            {
                return QueueCapacity - Queue.Count() ;
            }

            set
            {

            }

        }

        public Queue<IFactoryQueueElement> Queue { get; set; }

       public List<ITestingUnit> Storage { get; set; }

        public TimeSpan QueueTime { get; set; }


        public Action<object, EventArgs> FactoryStatus { get; set; }
       

        public UnitFactory(int queuecapacity , int storagecapacity)
        {
            this.Storage = new List<ITestingUnit>();
            this.Queue = new Queue<IFactoryQueueElement>();
            this.QueueCapacity = queuecapacity;
            this.StorageCapacity = storagecapacity;
        }

        public bool AddWorkableUnitToQueue(string Name, Type Model, Coordinates WorkingPos , Coordinates ParkingPos)
        {
            Object lockThis = new Object();

            if (Storage.Count() > StorageCapacity || Queue.Count() > QueueCapacity)
            {
                return false;
            }

            lock (lockThis)
            {
             
                Queue.Enqueue(new FactoryQueueElement { Name = Name, Model = Model, WorkingPos = WorkingPos, ParkingPos = ParkingPos });
                return true;
            }
           

        }
    }


}
