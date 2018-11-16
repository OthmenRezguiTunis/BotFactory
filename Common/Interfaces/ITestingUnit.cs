using BotFactory.Common.Tools;
using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces
{
  public  interface ITestingUnit : IBaseUnit , IBuildableUnit, IReportingUnit  , IWorkingUnit 
    {

  
    }
}
