using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamProject
{
    public class DevTeamRepo
    {
       
        private readonly List<DevTeam> _devTeams = new List<DevTeam>();
        private int id;


        //DevTeam Create
        public void AddDevTeamTolist(DevTeam team)
        {
            _devTeams.Add(team);
        }
        //DevTeam Read
        public List<DevTeam> GetDevTeams(string originialName)
        {
            return _devTeams;
        }

        //DevTeam Update
        public bool UpdatingExistingDeveloper(string OriginialName, DevTeam newDevTeam)
        {
            DevTeam olddev = GetDevTeams(OriginialName, newDevTeam);

            if (OriginialName != null)
            {
                olddev.Name = newDevTeam.Name;
                olddev.ID = newDevTeam.ID;
                return true;
            }

            else
            {
                return false;
            }
        }

        private DevTeam GetDevTeams(string originialName, DevTeam newDevTeam)
        {
            throw new NotImplementedException();
        }

        //DevTeam Delete

        //DevTeam Helper (Get Team by ID)
        public DevTeam GetDeveloperByID(int Id)
        {
            foreach (DevTeam teamid in _devTeams)
            {
                if (teamid.ID == id)
                {
                    return teamid;
                }
               
            } return null;
        }

    }
}
