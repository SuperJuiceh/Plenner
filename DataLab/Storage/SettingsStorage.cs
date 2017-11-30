﻿using DataLab.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace DataLab.Storage
{
    public class SettingsStorage: Storage<PlannerSettings>
    {
        
        public PlannerSettings Settings { get { return this.StorageObject; } set { this.StorageObject = value; } }

        public SettingsStorage(): base(StorageDefaults.DefaultSettingsPath)
        {

        }

        public void setPlannerSettings(PlannerSettings settings) {
            this.Settings = settings;
            saveStorage();
        }
                
    }
}
