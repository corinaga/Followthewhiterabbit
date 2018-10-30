using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RealWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            Matrix m = new Matrix();
            //Console.WriteLine(m.getCountQueue());

            //Cell c=m.whereIsNeo();
            //Console.WriteLine(c.getx());
            //Console.WriteLine(c.gety());
            m.printMatrix();
            Console.WriteLine("-----------------------------------------------------------------------------");
            //m.smithAction2();
            //Console.WriteLine("");
            //// m.printMatrix();
            //m.printMatrix();
            //Console.WriteLine("-----------------------------------------------");
            //m.actionNeo();
            //m.printMatrix();


            int max_time = 20;
            int time = 1;

            do
            {
                if (time % 1 == 0 && !m.end())
                {
                    Console.WriteLine("Action Pg");
                    m.actionPg();
                    m.printMatrix();
                    Console.WriteLine("-----------------------------------------------------------------------------");
                }


                if (time % 2 == 0 && !m.end())
                {
                    Console.WriteLine("Action Smith");
                    m.smithAction2();
                    m.printMatrix();
                    Console.WriteLine("-----------------------------------------------------------------------------");

                }

                if (time % 5 == 0 && !m.end())
                {
                    Console.WriteLine("Action Neo");
                    m.actionNeo();
                    m.printMatrix();
                    Console.WriteLine("-----------------------------------------------------------------------------");

                }

                Thread.Sleep(1000);
                time += 1;


            } while (time <= max_time && !m.end());


            Console.WriteLine("Remaining personages in the queue: " + m.getCountQueue());

        }
    }
}
