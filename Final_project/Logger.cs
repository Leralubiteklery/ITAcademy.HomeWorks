using log4net;
using log4net.Config;
using System.IO;
using System.Reflection;

namespace Final_project
{
    public static class Logger
    {
        private static ILog log = LogManager.GetLogger(typeof(Logger));

        public static ILog Log
        {
            get { return log; }
        }

        public static void InitLogger()
        {
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo("App.config"));
        }
    }
}
