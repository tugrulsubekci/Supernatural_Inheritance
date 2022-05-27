using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supernatural_Inheritance
{
    internal class Mage : Pupil
    {
        public Mage(string title) : base(title)
        {

        }

        public virtual Storm CastRainStorm()
        {
            return new Storm("Rain",false,Title);
        }

    }
}
