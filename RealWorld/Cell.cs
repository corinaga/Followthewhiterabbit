using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealWorld
{
    class Cell
    {
        private int x;
        private int y;




        public Cell(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int  getx()
        {
            return x;
        }

        public int gety()
        {
            return y;
        }
        public void setx(int x)
        {
            this.x = x;
        }


        public void sety(int y)
        {
            this.y = y;
        }

        public bool equals(Cell obj)
        {
            bool eq = false;
            if ((this.x==obj.getx()) && (this.y == obj.gety()))
            {
                eq = true;
            }

            return eq;
        }

    }
}
