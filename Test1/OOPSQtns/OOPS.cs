using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSQtns
{
    /// <summary>
    /// article about constructors
    /// https://www.codeproject.com/Articles/7011/An-Intro-to-Constructors-in-C
    /// </summary>
    class OOPS :Singleton
    {
        public OOPS()
        {
            //var single = Singleton.singleton;
            
            Console.ReadLine();
        }
        
    }
    /// <summary>
    /// singleton vs static
    /// </summary>
    public class Singleton
    {
        private static Singleton _singleton;

       
        static Singleton()
        {
            Console.WriteLine("static");
        }
        protected Singleton()
        {
            Console.WriteLine("protect");
        }

        public static object _lock = new object();

        public static Singleton GetInstance()
        {
            if (_singleton != null)
            {
                lock(_lock)
                {
                    _singleton = new Singleton();
                }                
            }
            return _singleton;
        }
        
    }
}
