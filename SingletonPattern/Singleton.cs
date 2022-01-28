using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    //Can not inherit 
    sealed class Singleton
    {

        private static Singleton obj = null;

        private static int counter = 0;

        //private constructor 
        //can not create instance directly 
        private Singleton()
        {
            
        }

        /// <summary>
        /// Create multiple instances using singleton 
        /// </summary>
        /// <returns></returns>
        public static Singleton GetSingleton()
        {

            counter++;
            
            if (counter <=  5)
            {
                obj = new Singleton();
                Console.WriteLine("Instance :" + counter + " created");
            }
            
            return obj;

        }

    }
}
