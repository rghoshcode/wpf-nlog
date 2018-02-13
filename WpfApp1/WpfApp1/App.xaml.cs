using NLog;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        #region Private Fields
        private static Logger logger = LogManager.GetCurrentClassLogger();
        #endregion

        public App()
        {
            logger.Log(LogLevel.Debug, $"In app.xaml.cs");
        }
        
            
    }
}
