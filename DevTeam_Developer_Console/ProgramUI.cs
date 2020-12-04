using DevTeam_Developer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeam_Developer_Console
{
    class ProgramUI

    {
        private DeveloperRepo _developerRepo = new DeveloperRepo();
        private DevTeamRepo _devTeamRepo = new DevTeamRepo();
        

        public void Run()
        {
            Menu();
        }

        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning == true)
            {
                Console.WriteLine("Select a menu option\n" +
                    "1. Create or add a new Developer\n" +
                    "2. View all Developers\n" +
                    "3. View Developer by thieID Numbers\n" +
                    "4. Update existing Developer\n" +
                    "5. Delete previous Developer\n" +
                    "6. Add Developer to the team\n" +
                    "7. View Developers in dev team\n" +
                    "8. Update Developer in dev team\n" +
                    "9. Delete Developer from dev team\n" +
                    "10. Exist");
                string input = Console.ReadLine();
                //Evalute the user's input and act accordintly
                switch (input)
                {
                    case "1":
                        //create developer
                        AddNewMemeber();
                        break;
                    case "2":
                        //View all Developers
                        ViewDevelopers();
                        break;
                    case "3":
                        //Display Developer by Id number
                        ViewDevelopersByID();
                        break;
                    case "4":
                        //Update existing Developer
                        UpdateExistingDeveloper();
                        break;
                    case "5":
                        //delete
                        DeleteDeveloper();
                        break;
                    case "6":
                        // add developers to Team
                        AddDeveloperTeam();
                        break;
                    case "7":
                        //view Develper
                        break;

                    case "8":
                        // update
                        break;
                    case "9":
                        // delete
                        break;
                    case "10":
                        //Exit
                        Console.WriteLine("Goodbye");
                        keepRunning = false;
                        break;

                    default:
                        Console.WriteLine("Please Enter a vaild ID Number.");
                        break;
                }
                Console.WriteLine("press any key to continue");
                Console.ReadKey();
                Console.Clear();
            }
        }

        // create Developer
        private void AddNewMemeber()
        {
            Console.Clear();
            Developer newdeveloper = new Developer();
            //ID Numbers
            Console.WriteLine("Please enter Developer's ID Number");
            string IDNumberAsString = Console.ReadLine();
            newdeveloper.IDNumber = int.Parse(IDNumberAsString);

            //Name
            Console.WriteLine("Please Enter Developer's name");
            newdeveloper.Name = Console.ReadLine();

            //Type of developers
            Console.WriteLine("Please Enter Developer Type \n" +
                "1.SoftwareDeveloper \n" +
                "2.DatabaseDevelope \n" +
                "3.NetworkDeveloper \n" +
                "4.WebDeveloper");
            string TypeOdDeveloperAsString = Console.ReadLine();
            int number = int.Parse(TypeOdDeveloperAsString);
            newdeveloper.TypeOfDeveloper = (DeveloperType)number;


            //can access
            Console.WriteLine("Can developer access the Pularsight y/n");
            string canAccessPularsightString = Console.ReadLine();
            if (canAccessPularsightString == "y")
            {
                newdeveloper.CanAccessPurasight = true;
            }
            else
            {
                newdeveloper.CanAccessPurasight = false;
            }

            _developerRepo.AddDeveloperTolist(newdeveloper);
        }
        private void ViewDevelopers()
        {
            Console.Clear();
            List<Developer> listOfDevelpers = _developerRepo.GetDeveloper();
            foreach (Developer developer in listOfDevelpers)
            {
                Console.WriteLine($"Developer:{developer.IDNumber}, Name: {developer.Name}");
            }
        }

        //View Developers by IDNumbers
        private void ViewDevelopersByID()
        {
            Console.Clear();
            Console.WriteLine("Enter Developer's ID Number");
            string idNumber = Console.ReadLine();
            int newID = int.Parse(idNumber);

            Developer developer = _developerRepo.GetDeveloperByIDNumber(newID);

            if (developer != null)
            {
                Console.WriteLine($"Developer: {developer.IDNumber}\n" +
                    $"Name: { developer.Name}\n" +
                    $"Can Access : {developer.CanAccessPurasight}");
            }

            else
            {
                Console.WriteLine("There is no Developer by that ID Number");
            }
        }
        //update existing Developer
        private void UpdateExistingDeveloper()
        {
            ViewDevelopers();

            //Id Number
            Console.WriteLine("Please Enter the Id Number you would like to update");
            string olID = Console.ReadLine();

            int id = int.Parse(olID);
            Console.Clear();

            Developer newDeveloper = new Developer();

            // ID Numbers
            Console.WriteLine("Please enter Developer's ID Number");
            string IDNumberAsString = Console.ReadLine();
            newDeveloper.IDNumber = int.Parse(IDNumberAsString);

            //Name
            Console.WriteLine("Please Enter Developer's name");
            newDeveloper.Name = Console.ReadLine();

            //Type of developers
            Console.WriteLine("Please Enter Developer Type \n" +
                "1.SoftwareDeveloper \n" +
                "2.DatabaseDevelope \n" +
                "3.NetworkDeveloper \n" +
                "4.WebDeveloper");
            string TypeOdDeveloperAsString = Console.ReadLine();
            int number = int.Parse(TypeOdDeveloperAsString);
            newDeveloper.TypeOfDeveloper = (DeveloperType)number;

            //can access
            Console.WriteLine("Can developer access the Pularsight y/n");
            string canAccessPularsightString = Console.ReadLine();
            if (canAccessPularsightString == "y")
            {
                newDeveloper.CanAccessPurasight = true;
            }

            else
            {
                newDeveloper.CanAccessPurasight = false;
            }

            bool wasUpdated = _developerRepo.UpdateExistingDevelopers(id, newDeveloper);
            if (wasUpdated)
            {
                Console.WriteLine("Developer Id was updated");
            }

            else
            {
                Console.WriteLine("Developer Id was not updated");
            }
        }
        //Delete
        private void DeleteDeveloper()
        {
            Console.Clear();
            ViewDevelopers();
            Console.WriteLine("Enter the ID Number You like to remove");
            string deletedId = Console.ReadLine();
            int iDeletedId = int.Parse(deletedId);
            bool wasDeleted = _developerRepo.RemoveDeveloperFromlist(iDeletedId);
            if (wasDeleted)
            {
                Console.WriteLine("ID Number was succesfully deleted");
            }

            else
            {
                Console.WriteLine("The Id Number cannot be deleted");
            }

            
            }
        //create
        private void AddDeveloperTeam()
        {
            Console.Clear();
            DevTeam newTeam = new DevTeam();
            Console.WriteLine("Please enter developer's id you like to add to the team:");
            string input =  Console.ReadLine();
            newTeam.IDNumber = int.Parse(input);
            ViewDevelopersByID();
            Console.WriteLine("Please select developer Id from the list you like to Add:");
            string inPut2 = Console.ReadLine();
            int val = int.Parse(inPut2);

            DevTeam dev = _devTeamRepo.GetDevTeamByID(val);
            _devTeamRepo.AddDevTeamTolist(dev);

        }

        

        }
    }

