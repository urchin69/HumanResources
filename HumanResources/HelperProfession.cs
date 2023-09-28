using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources
{


    class HelperProfession
    {

        public static List<Profession> GetProfession(string defaultProfession)
        {

            return new List<Profession>
            {
                //new Profession {Id = 0, ProfessionName= defaultProfession},
                new Profession {Id = 0, ProfessionName= ""},
                new Profession {Id = 1, ProfessionName ="Hydraulik"},
                new Profession {Id = 2, ProfessionName ="Elektryk"},
                new Profession {Id = 3, ProfessionName ="Magazynier"},
                new Profession {Id = 4, ProfessionName ="Księgowy"},
                new Profession {Id = 5, ProfessionName ="Dyrektor"},
                new Profession {Id = 6, ProfessionName ="Sprzedawca"},
                new Profession {Id = 7, ProfessionName ="Pracownik fizyczny"},
                new Profession {Id = 8, ProfessionName ="Pomocnik magazyniera"},
                new Profession {Id = 9, ProfessionName ="Informatyk"}

            };
        }
    }
}