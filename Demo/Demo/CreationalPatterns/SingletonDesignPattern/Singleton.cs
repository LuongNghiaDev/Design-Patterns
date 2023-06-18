using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.CreationalPatterns.SingletonDesignPattern
{
    public class Singleton
    {

        private static volatile Singleton uniqueSingleton;
        private static readonly object lockObject = new object();

        private Singleton()
        {

        }

        public static Singleton GetInstance()
        {
            //lazy
            if (uniqueSingleton == null)
            {
                lock (lockObject)
                {
                    if (uniqueSingleton == null)
                    {
                        uniqueSingleton = new Singleton();
                    }
                }
            }
            return uniqueSingleton;
        }
    }
}
