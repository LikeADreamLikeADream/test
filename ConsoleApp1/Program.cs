using Common.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        private static ILog Logger = LogManager.GetLogger("DBFactoryInfo");
        static void Main(string[] args)
        {
            Class1.Test2();


            Console.WriteLine("Test");
            Console.ReadLine();
        }
        
        public static void Test()
            {
            string str="次方法是拉取代码后，第一次更改";

          }
        public static void TestTwo()
            {
             string str="此方法是拉取代码后，第二次更改";
}
    }
}
