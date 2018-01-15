using Common.Logging;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QY.Quartz.Net.Jobs
{
    /// <summary>
　　/// 实现IJob接口
　　/// </summary>
　　public class Job1 : IJob
    {
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public void Execute(IJobExecutionContext context)
        {

            try
            {
                logger.Info("Job1 任务运行开始");

                for (int i = 0; i < 5; i++)
                {

                    Thread.Sleep(100);
                    logger.InfoFormat("Job1 正在运行{0}", i);
                }

                logger.Info("Job1任务运行结束");
            }
            catch (Exception ex)
            {
                logger.Error("Job1 运行异常", ex);
            }

        }
    }
}
