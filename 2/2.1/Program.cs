﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace CounterTest
{
    public class Program
    {

        public static void Main()
        {
            Counter[] myCounters = new Counter[3];
            myCounters[0] = new Counter("Counter 1");
            myCounters[1] = new Counter("Counter 2");
            myCounters[2] = myCounters[0];

            for (int i = 0; i < 5; i++)
            {
                myCounters[0].Increment();
            }

            for (int i = 0; i < 10; i++)
            {
                myCounters[1].Increment();
            }

            PrintCounters(myCounters);
            myCounters[2].Reset();
            PrintCounters(myCounters);


        }

        private static void PrintCounters(Counter[] counters)
        {
            foreach (var c in counters)
            {
                Console.WriteLine("{0} is {1}", c.Name, c.Ticks);
            }

        }
    }
}