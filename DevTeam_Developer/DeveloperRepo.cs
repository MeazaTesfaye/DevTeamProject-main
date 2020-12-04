using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeam_Developer
{
    public class DeveloperRepo
    {
        private readonly List<Developer> _developerDirectory = new List<Developer>();

        //Developer Create
        public void AddDeveloperTolist(Developer developer)
        {
            _developerDirectory.Add(developer);
        }

        //Developer Read
        public List<Developer> GetDeveloper()
        {
            return _developerDirectory;
        }
        public void AddDeveloperTolist()
        {
            throw new NotImplementedException();
        }

        //Developer Update
        public bool UpdateExistingDevelopers(int PreviousDevelopers, Developer newDeveloper)
        {
            //Find Developer TeampreviousDevelopers
            Developer oldEmployee = GetDeveloperByIDNumber(PreviousDevelopers);
            // Update Developers Team
            if (oldEmployee != null)
            {
                oldEmployee.IDNumber = newDeveloper.IDNumber;
                oldEmployee.Name = newDeveloper.Name;
                oldEmployee.TypeOfDeveloper = newDeveloper.TypeOfDeveloper;
                oldEmployee.CanAccessPurasight = newDeveloper.CanAccessPurasight;
                return true;
            }

            else
            {
                return false;
            }
        }

        //Developer Delete
        public bool RemoveDeveloperFromlist(int number)
        {
            Developer developer = GetDeveloperByIDNumber(number);
            if (developer == null)
            {
                return false;
            }
            int initialCount = _developerDirectory.Count;
            _developerDirectory.Remove(developer);

            if (initialCount > _developerDirectory.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Developer Helper (Get Developer by ID)
        public Developer GetDeveloperByIDNumber(int idNumber)
        {
            foreach (Developer developer in _developerDirectory)
            {
                if (developer.IDNumber == idNumber)
                {
                    return developer;
                }
            }

            return null;
        }


    }
}
