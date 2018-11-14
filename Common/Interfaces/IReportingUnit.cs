using Common;
using System;

namespace Common.Interfaces
{
    public interface IReportingUnit
    {
        event EventHandler<IStatusChangedEventArgs> UnitStatusChanged;

        void OnStatusChanged(IStatusChangedEventArgs e);
    }
}