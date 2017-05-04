using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serpientes_escaleras
{
    class Dado
    {
        static Random n = new Random();
        public int lanzar()
        {
            return n.Next(1, 7);

        }

    }
}
