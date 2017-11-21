using DataLab.Data.Work;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLab.Storage
{
    public class WorkStorage: Storage<WorkManager>
    {
        public WorkStorage(): base("work.sv")
        {

        }
    }
}
