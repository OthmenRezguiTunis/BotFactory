using System;
using BotFactory.Common.Tools;

namespace Factory
{
    public interface IFactoryQueueElement
    {
        Type Model { get; set; }
        string Name { get; set; }
        Coordinates ParkingPos { get; set; }
        Coordinates WorkingPos { get; set; }
    }
}