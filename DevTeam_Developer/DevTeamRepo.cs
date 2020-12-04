using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeam_Developer
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
                olddev.IDNumber = newDevTeam.IDNumber;
                olddev._developes = newDevTeam._developes;
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
        public bool DeleteDevs(int idNum)
        {
            DevTeam devTeam = GetDevTeamByID(idNum);
            if(devTeam == null)
            {
                return false;
            }
            int intialCount = _devTeams.Count;
            _devTeams.Remove(devTeam);
            if (intialCount > _devTeams.Count)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        //DevTeam Helper (Get Team by ID)
        public DevTeam GetDevTeamByID(int Id)
        {
            foreach (DevTeam teamid in _devTeams)
            {
                if (teamid.IDNumber == id)
                {
                    return teamid;
                }

            }
            return null;
        }

    }
}
