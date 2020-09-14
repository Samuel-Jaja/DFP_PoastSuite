using System;
using System.Collections.Generic;
using System.Text;

namespace DFP_PoastSuite
{
    class Singleton
    {
        private static Singleton  instance = null;
        private Singleton() { }

        public static Singleton Instance
        {
            get 
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }

        public void DoSomething() 
        {
            Console.WriteLine("Singleton class code has been called for SJ");
            Console.ReadLine();
        }


    }
}
