using BotFactory.Common.Tools;
using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factories
{
    public class FactoryQueueElement : IFactoryQueueElement
    {
        public string Name { get; set; }

        public Type Model { get; set; }

        public Coordinates WorkingPos { get; set; }

        public Coordinates ParkingPos { get; set; }




    }
}
