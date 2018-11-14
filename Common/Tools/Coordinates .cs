using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotFactory.Common.Tools
{
   public  class Coordinates
    {
        public double X { get; set; }
        public double Y { get; set; }

        public override bool Equals(object obj)
        {
            var item = obj as Coordinates;

            if (item == null)
            {
                return false;
            }

            return (this.X == item.X && this.Y == item.Y);
        }


        public override int GetHashCode()
        {
            return GetHashCode();
        }
    }

  


}
