using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace watkiZad3
{
    class Program
    {
        static void Main(string[] args)
        {
            int zmiennaKrytyczna = new int();
            object Baton = new object();
            int iteration = 800;

            Task T1 = Task.Run(() =>
            {
                for (int i = 0; i < iteration; i++)
                {
                    int random1 = new int();
                    lock(Baton)
                    {
                        int robocza = zmiennaKrytyczna;
                        robocza = robocza + 1;
                        Random rand1 = new Random();
                        random1 = rand1.Next(10);
                        zmiennaKrytyczna = robocza;
                        Console.WriteLine("Thread1 ----- iteracja " + i + "   " + zmiennaKrytyczna + "        random " + random1);
                    }
                    //Thread.Sleep(random1);
                }
                
            });

            Task T2 = Task.Run(() =>
            {
                for (int i = 0; i < iteration; i++)
                {
                    int random2 = new int();
                    lock (Baton)
                    {
                        int robocza = zmiennaKrytyczna;
                        robocza = robocza + 1;
                        Random rand2 = new Random();
                        random2 = rand2.Next(10);
                        zmiennaKrytyczna = robocza;
                        Console.WriteLine("Thread2 ----- iteracja " + i + "   " + zmiennaKrytyczna + "        random " + random2);
                    }
                    //Thread.Sleep(random2);
                }
                
            });
            Task T3 = Task.Run(() =>
            {
                for (int i = 0; i < iteration; i++)
                {
                    int random3 = new int();
                    lock (Baton)
                    {
                        int robocza = zmiennaKrytyczna;
                        robocza = robocza + 1;
                        Random rand3 = new Random();
                        random3 = rand3.Next(20);
                        zmiennaKrytyczna = robocza;
                        Console.WriteLine("Thread3 ----- iteracja " + i + "   " + zmiennaKrytyczna + "        random " + random3);
                    }
                    //Thread.Sleep(random3);
                }

            }); Task T4 = Task.Run(() =>
            {
                for (int i = 0; i < iteration; i++)
                {
                    int random4 = new int();
                    lock (Baton)
                    {
                        int robocza = zmiennaKrytyczna;
                        robocza = robocza + 1;
                        Random rand4 = new Random();
                        random4 = rand4.Next(100);
                        zmiennaKrytyczna = robocza;
                        Console.WriteLine("Thread4 ----- iteracja " + i + "   " + zmiennaKrytyczna + "        random " + random4);
                    }
                    //Thread.Sleep(random4);
                }

            });

            Console.ReadKey();
        }
    }
}
