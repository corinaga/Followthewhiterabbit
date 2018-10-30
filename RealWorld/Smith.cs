using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealWorld
{
    class Smith : Personages
    {
        
        public int infect;
        private readonly int MAX = 8;

        public Smith()
        {
            this.infect = getInfect();

            
        }


        public int getInfect()
        {
            return Usefuls.random_Number(1, this.MAX);
        }

    }
}
