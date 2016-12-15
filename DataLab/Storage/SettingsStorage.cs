using DataLab.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLab.Storage
{
    public class SettingsStorage: Storage
    {
        
        public PlannerSettings Settings { get { return (PlannerSettings)this.StorageObject; } set { this.StorageObject = value; } }

        public SettingsStorage(): base("settings.pln", typeof(PlannerSettings))
        {

        }

        public void setPlannerSettings(PlannerSettings settings) {
            this.Settings = settings;
            saveStorage();
        }
                
    }
}
