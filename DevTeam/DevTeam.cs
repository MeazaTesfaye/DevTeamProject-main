using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamProject
{
    public class DevTeam
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public bool WhoCanAccess { get; set; }
        public int IDNumber { get; set; }

        public DevTeam() { }

        public DevTeam(string name, int id, bool whoCanAccess)
        {
            Name = name;
            ID = id;
            WhoCanAccess = whoCanAccess;
        }
    }

}
