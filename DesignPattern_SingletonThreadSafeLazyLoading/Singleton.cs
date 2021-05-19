﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_SingletonThreadSafeLazyLoading
{
    public sealed class Singleton
    {
        private static int counter = 0;

        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }

        private static readonly Lazy<Singleton> Instancelock =
                    new Lazy<Singleton>(() => new Singleton());

        public static Singleton GetInstance
        {
            get
            {
                return Instancelock.Value;
            }
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}