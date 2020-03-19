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
        public static void TestTwo()
        {
            string str="Uat分支拉取第二次修改";
        }
        public static void TestS()
        {
            string Str="此方法是重置实验，重置后是否会返回上一个版本";
        }   
        
        public static void Test1()
            {
            string str="次方法是拉取代码后，第一次更改";

          }
    }
}
