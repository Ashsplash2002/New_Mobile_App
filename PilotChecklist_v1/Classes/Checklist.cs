using System;
using System.Collections.Generic;
using System.Text;

namespace PilotChecklist.Classes
{
    internal class Checklist
    {
        int id;
        decimal progress;
        bool isCompleted;
        int flightId;

        public int Id { get { return id; } set { id = value; } }
        public decimal Progress { get { return progress; } set { progress = value; } }
        public bool IsCompleted { get {  return isCompleted; } set {  isCompleted = value; } }
        public int FlightId { get {  return flightId; } set {  flightId = value; } }

        public Checklist()
        {

        }

        public Checklist(int id, decimal progress, bool isCompleted, int flightId)
        {
            Id = id;
            Progress = progress;
            IsCompleted = isCompleted;
            FlightId = flightId;
        }
    }
}
