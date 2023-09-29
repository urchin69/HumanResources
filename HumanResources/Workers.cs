using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources
{
    public class Workers
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int WorkerStatus { get; set; }
        public DateTime DateBorn { get; set; }
        public DateTime DateGetJob { get; set; }
        public DateTime? DateFall { get; set; }
        public decimal PrimSalary { get; set; }
        public int PositionWork { get; set; }
        public string Coments { get; set; }
        public bool cbDateFall { get; set; }
      

    }
}
