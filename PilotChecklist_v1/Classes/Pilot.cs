using System;
using System.Collections.Generic;
using System.Text;

namespace PilotChecklist.Classes
{
    internal class Pilot
    {
        int id;
        string name;
        string surname;
        string username;
        string password;
        int checklistId;
        List<Flight> flights;

        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Surname { get { return surname; } set { surname = value; } }
        public string Username { get { return username; } set { username = value; } }
        public string Password { get { return password; } set { password = value; } }
        public int ChecklistId {  get { return checklistId; } set {  checklistId = value; } }
        public List<Flight> Flights { get {  return flights; } set {  flights = value; } }

        public Pilot()
        {

        }

        public Pilot(int id, string name, string surname, string username, string password, int checklistId, List<Flight> flights)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Username = username;
            Password = password;
            ChecklistId = checklistId;
            Flights = flights;
        }
    }
}
