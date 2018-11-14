using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotFactory.Common.Tools
{
    public class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }

        public static Vector FromCoordinates(Coordinates begin , Coordinates End)
        {
            var vect = new Vector();
            vect.X = End.X - begin.X;
            vect.Y = End.Y - begin.Y;
            return vect;

        }

        public double Length()
        {
            return Math.Sqrt((this.X*this.X) + (this.Y* this.Y ));

        }
    }
}
