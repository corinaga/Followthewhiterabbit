using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealWorld
{
    class Neo : Personages
    {
        public bool believed;

        public Neo()
        {

            this.believed = isBelieved();
        }

        public bool isBelieved()
        {
            int num = Usefuls.random_Number(0, 2);

            if (num == 0)
            {
                this.believed = false;
            }
            else
            {
                this.believed = true;
            }

            return this.believed;
        }



    }
}
