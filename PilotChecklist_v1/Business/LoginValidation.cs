using PilotChecklist.Classes;
using PilotChecklist_v1.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace PilotChecklist_v1.Business
{
    internal class LoginValidation
    {
        SelectOperations selectOps = new SelectOperations();

        public bool Login(string username, string password)
        {
            List<Pilot> pilots = selectOps.SelectPilots();

            foreach (Pilot pilot in pilots)
            {
                if(pilot.Username ==  username && pilot.Password == password)
                {
                    GlobalVariables.pilot = pilot;
                    Console.WriteLine($"Pilot Found !\t\t {pilot.Id} {pilot.Name} {pilot.Surname} | FlightID: {pilot.FlightId}");

                    return true;
                }
            }

            return false;
        }
    }
}
