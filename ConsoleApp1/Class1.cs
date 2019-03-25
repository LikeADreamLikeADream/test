using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Class1
    {
        #region Quartz定时任务框架
        public static void Test2()
        {
            //创建一个调度器工厂
            var props = new NameValueCollection
                {
                    { "quartz.scheduler.instanceName", "QuartzDotNetDemo" }
                };
            var factory = new StdSchedulerFactory(props);

            //获取调度器
            var sched = factory.GetScheduler();
            sched.Start();

            IJobDetail job = JobBuilder.Create<HelloJob>().WithIdentity("sampleJob", "sampleGroup").Build();

            //3、创建一个触发器
            ISimpleTrigger trigger = (ISimpleTrigger)TriggerBuilder.Create()
                                                        .WithIdentity("trigger1", "group1")
                                                        .WithSimpleSchedule(x => x.WithIntervalInSeconds(1).RepeatForever())
                                                        .Build();
            sched.ScheduleJob(job, trigger);

        }
        [DisallowConcurrentExecution]
        public class HelloJob : IJob
        {

            public void Execute(IJobExecutionContext context)
            {

                Console.WriteLine("Greetings from HelloJob!");

            }
        }

        #endregion
    }
}
