using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supernatural_Inheritance
{
    internal class Pupil
    {
        public string Title { get; private set; }
        public Pupil(string title)
        {
            Title = title;
        }

        public Storm CastWindStorm()
        {
            return new Storm("wind", false, Title);
        }
    }
}
