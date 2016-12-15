using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Windows.ApplicationModel.Core;

namespace DataLab.Server.Controller.Logging
{
    public class ServerLog
    {
        [XmlArray("Logs"), XmlArrayItem(typeof(Log), ElementName = "Log")]
        public ObservableCollection<Log> Logs { get; set; } = new ObservableCollection<Log>();
        [XmlArray("LogHistory"), XmlArrayItem(typeof(Log), ElementName = "Log")]
        public ObservableCollection<Log> LogHistory { get; set; } = new ObservableCollection<Log>();

        public ServerLog()
        {

        }

        public void addLog(string name)
        {
            addLog(name, Log.LogTypes.Server_Status);
        }

        public async void addLog(string name, Log.LogTypes lType)
        {
            await CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.High, () =>
            {
                Logs.Add(new Log(DateTime.Now, name, lType));
            });
        }

        public enum LogClearingOptions { CLEAR_CURRENT, CLEAR_AND_STORE, REMOVE_ALL }

        public void clearLogs(LogClearingOptions clearOptions)
        {
            if (clearOptions == LogClearingOptions.REMOVE_ALL)
            {
                // Remove all logs
                LogHistory.Clear();
                Logs.Clear();
            }
            else if (clearOptions == LogClearingOptions.CLEAR_AND_STORE)
            {
                // Add all logs to history
                Logs.ToList().ForEach(log => LogHistory.Add(log));
                // Then clear
                Logs.Clear();
            }
            else if (clearOptions == LogClearingOptions.CLEAR_CURRENT)
            {
                Logs.Clear();
            }
        }
    }
}
