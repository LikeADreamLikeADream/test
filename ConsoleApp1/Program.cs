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
            string str="Uat分支拉取第一次修改";
           }
    }
}
