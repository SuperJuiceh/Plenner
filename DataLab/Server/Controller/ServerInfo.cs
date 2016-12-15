using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataLab.Server.Controller
{
    public class ServerInfo: INotifyPropertyChanged
    {
        [XmlIgnore]
        private string _name;
        // Name
        public string Name { get { return _name; } set { _name = value; Changed("Name"); } }
        
        public DateTime RunningSince { get; set; }
        [XmlIgnore]
        private RunningStatus _runStatus;
        // Running
        public RunningStatus RunStatus { get { return _runStatus; } set { _runStatus = value; Changed("RunStatus"); } }

        public ServerInfo(string Name)
        {
            this.Name = Name;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void start()
        {
            this.RunningSince   =   DateTime.Now;
            this.RunStatus      =   RunningStatus.RUNNING;
        }

        public void pause()
        {
            this.RunStatus = RunningStatus.PAUSED;
        }

        public void stop()
        {
            this.RunStatus = RunningStatus.STOP;
        }
        
        // Enums
        public enum RunningStatus
        {
            STOP,
            PAUSED,
            RUNNING
        }

        public void Changed(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        public ServerInfo() { }
    }
}
