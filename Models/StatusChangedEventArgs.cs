
using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class StatusChangedEventArgs : EventArgs, IStatusChangedEventArgs
    {
        public string NewStatus{  get; set; }


        public StatusChangedEventArgs(string status)
        {
            this.NewStatus = status;
        }
    }
}
