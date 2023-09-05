using System;
using System.Collections.Generic;
using System.Text;

namespace PilotChecklist.Classes
{
    internal class Flight
    {
        int id;
        string flightFrom;
        string flightTo;
        string departureTime;
        string arrivalTime;
        int pilotId;
        int checklistId;

        public int Id { get { return id; } set {  id = value; } }
        public string FlightFrom { get {  return flightFrom; } set {  flightFrom = value; } }
        public string FlightTo { get {  return flightTo; } set { flightTo = value; } }
        public string DepartureTime { get {  return departureTime; } set {  departureTime = value; } }
        public string ArrivalTime { get { return arrivalTime; } set {  arrivalTime = value; } }
        public int PilotId { get {  return pilotId; } set {  pilotId = value; } }
        public int ChecklistId { get { return checklistId; } set {  checklistId = value; } }

        public Flight()
        {

        }

        public Flight(int id, string from, string to, string departureTime, string arrivalTime, int pilotId, int checklistId)
        {
            Id = id;
            FlightFrom = from;
            FlightTo = to;
            DepartureTime = departureTime;
            ArrivalTime = arrivalTime;
            PilotId = pilotId;
            ChecklistId = checklistId;
        }
    }
}
