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
    /// 
    /// singleton vs static:
    /// Singleton objects are stored in Heap, but static objects are stored in stack.
    ///We can clone(if the designer did not disallow it) the singleton object, 
    ///but we can not clone the static class object .
    ///Singleton classes follow the OOP(object oriented principles), static classes do not.
    ///We can implement an interface with a Singleton class,
    ///but a class's static methods (or e.g. a C# static class) cannot. 
    /// </summary>
    /// singleton
    /// </summary>
    public class Singleton
    {
        private static Singleton _singleton;

       
        static Singleton()
        {
            Console.WriteLine("static");
        }
        private Singleton()
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
