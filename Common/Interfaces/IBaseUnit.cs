using System.Threading.Tasks;
using BotFactory.Common.Tools;

namespace Common.Interfaces
{
    public interface IBaseUnit
    {
        Coordinates CurrentPos { get; set; }
        string Name { get; set; }
        double Speed { get; set; }

        Task Move(Coordinates x, Coordinates y);
    }
}