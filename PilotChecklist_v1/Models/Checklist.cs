using System;
using System.Collections.Generic;
using System.Text;

namespace PilotChecklist_v1.Models
{
    internal class Checklist
    {
        int id;
        string progress;
        bool isCompleted;
        DateTime timestamp;


        public int Id { get { return id; } set { id = value; } }
        public string Progress { get { return progress; } set { progress = value; } }
        public bool IsCompleted { get { return isCompleted; } set { isCompleted = value; } }
        public DateTime Timestamp { get { return timestamp; } set { timestamp = value; } }

        public Checklist()
        {

        }

        public Checklist(int id, string progress, bool isCompleted, DateTime timestamp)
        {
            Id = id;
            Progress = progress;
            IsCompleted = isCompleted;
            Timestamp = timestamp;
        }
    }
}
