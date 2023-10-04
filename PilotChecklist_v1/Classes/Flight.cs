using System;
using System.Collections.Generic;
using System.Text;

namespace PilotChecklist.Classes
{
    internal class Flight
    {
        int id;
        string flightName;
        string flightFrom;
        string flightTo;
        string departureTime;
        string arrivalTime;
        int checklistId;

        public int Id { get { return id; } set { id = value; } }
        public string FlightName { get { return flightName; } set { flightName = value; } }
        public string DestinationFrom { get { return flightFrom; } set { flightFrom = value; } }
        public string DestinationTo { get { return flightTo; } set { flightTo = value; } }
        public string DepartureTime { get { return departureTime; } set { departureTime = value; } }
        public string ArrivalTime { get { return arrivalTime; } set { arrivalTime = value; } }
        public int ChecklistId { get { return checklistId; } set { checklistId = value; } }

        public Flight()
        {

        }

        public Flight(int id, string name, string from, string to, string departureTime, string arrivalTime, int checklistId)
        {
            Id = id;
            FlightName = name;
            DestinationFrom = from;
            DestinationTo = to;
            DepartureTime = departureTime;
            ArrivalTime = arrivalTime;
            ChecklistId = checklistId;
        }
    }
}