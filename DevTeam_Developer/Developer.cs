using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeam_Developer
{
    public enum DeveloperType
    {
        SoftwareDevelopers = 1,
        DatabaseDeveloper,
        NetworkDeveloper,
        WebDeveloper
    }
    //Poco
    public class Developer
    {
        public string Name { get; set; }
        public int IDNumber { get; set; }
        public bool CanAccessPurasight { get; set; }
        public DeveloperType TypeOfDeveloper { get; set; }
        public Developer() { }

        public Developer(string name, int idNumber, bool canAccessPuralsight, DeveloperType devType)
        {
            Name = name;
            IDNumber = idNumber;
            CanAccessPurasight = canAccessPuralsight;
            TypeOfDeveloper = devType;
        }
    }

}
