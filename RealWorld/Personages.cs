using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealWorld
{
    class Personages : Generic
    {
        private String name;
        private readonly String[] names = { "Michelle ", "Alexander","James    ", "Caroline ", "Claire   ", "Jessica  ", "Erik     ", "Mike     "};
        private int age;
        private int percentageDie;
        private Location location;



        public Personages()
        {
            this.name = names[Usefuls.random_Number(0, 7)];
            this.age = Usefuls.random_Number(1, 100);
            this.percentageDie = Usefuls.random_Number(1, 101);
            this.location = new Location();
        }


        internal class Location
        {
            private readonly String[] cities = { "Nueva York", "Boston", "Baltimore", "Atlanta", "Detroit", "Dallas",  "Denver"};
            public int latitude;
            public int longitude;
            public String city;

            public Location()
            {
                this.city = cities[Usefuls.random_Number(0, 7)];
                this.latitude = Usefuls.random_Number(0, 91);
                this.longitude = Usefuls.random_Number(0, 360);
            }

        }

        public void generate()
        {
            throw new NotImplementedException();
        }

        public void print()
        {
            throw new NotImplementedException();
        }

        public void prompt()
        {
            throw new NotImplementedException();
        }

        public String getNombre()
        {
            return this.name;
        }

        public int getPercentageDie()
        {
            return this.percentageDie;
        }

        public void setPercentageDie(int per)
        {
            this.percentageDie=per;
        }

    }
}
