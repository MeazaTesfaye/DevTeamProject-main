using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeam_Developer
{
    public class DevTeam
    {
        public string Name { get; set; }
        public bool WhoCanAccess { get; set; }
        public int IDNumber { get; set; 
        public List<Developer> _developes { get; set; }

        public DevTeam() { }

        public DevTeam(string name, int idNumber, bool whoCanAccess, List<Developer> developer)
        {
            Name = name;
            IDNumber = idNumber;
            WhoCanAccess = whoCanAccess;
            _developes = developer;
        }
    }
}
