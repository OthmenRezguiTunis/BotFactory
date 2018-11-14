using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Common.Interfaces;

namespace Models
{
  public abstract class ReportingUnit : BuildableUnit, IReportingUnit
    {

        public event EventHandler<IStatusChangedEventArgs> UnitStatusChanged;

        public virtual void OnStatusChanged(IStatusChangedEventArgs e )
        {
            UnitStatusChanged?.Invoke(this, e);
        }
    }
}
