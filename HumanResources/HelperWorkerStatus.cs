using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources
{
    class HelperWorkerStatus
    {

        public static List<WorkerStatus> GetWorkerStatus(string defaultWorkerStatus)
        {

            return new List<WorkerStatus>
            {
                new WorkerStatus {Id = 0, StatusName= defaultWorkerStatus},
                new WorkerStatus {Id = 1, StatusName ="Zatrudniony"},
                new WorkerStatus {Id = 2, StatusName ="Zwolniony"},

            };
        }



    }
}
