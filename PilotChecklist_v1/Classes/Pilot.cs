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
        int flightId;

        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Surname { get { return surname; } set { surname = value; } }
        public string Username { get { return username; } set { username = value; } }
        public string Password { get { return password; } set { password = value; } }
        public int FlightId { get { return flightId; } set { flightId = value; } }

        public Pilot()
        {

        }

        public Pilot(int id, string name, string surname, string username, string password, int flightId)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Username = username;
            Password = password;
            FlightId = flightId;
        }
    }
}
