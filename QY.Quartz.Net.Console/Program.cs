using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace QY.Quartz.Net.Console
{

    class Program
    {
        static void Main(string[] args)
        {
            string servicename = ConfigurationManager.AppSettings["WindowsServiceName"];
            string displayname = ConfigurationManager.AppSettings["WindowsServiceDisplayName"];
            string sescription = ConfigurationManager.AppSettings["WindowsServiceDescription"];
            HostFactory.Run(x =>
            {
                x.Service<WindowsService>();
                x.RunAsLocalSystem();

                x.SetServiceName(servicename);
                x.SetDisplayName(displayname);
                x.SetDescription(sescription);

                x.EnablePauseAndContinue();
            });
        }
    }
}
