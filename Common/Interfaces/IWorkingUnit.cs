using System.Threading.Tasks;
using BotFactory.Common.Tools;

namespace Common.Interfaces
{
    public interface IWorkingUnit
    {
        bool IsWorking { get; set; }
        Coordinates ParkingPos { get; set; }
        Coordinates WorkingPos { get; set; }

        Task WorkBegins();
        Task WorkEnds();
    }
}