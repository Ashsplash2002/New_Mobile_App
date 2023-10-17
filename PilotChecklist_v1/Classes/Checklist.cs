using System;
using System.Collections.Generic;
using System.Text;

namespace PilotChecklist.Classes
{
    internal class Checklist
    {
        int id;
        bool isCompleted;
        byte[] timestamp;


        public int Id { get { return id; } set { id = value; } }
        public bool IsCompleted { get { return isCompleted; } set { isCompleted = value; } }
        public byte[] Timestamp { get { return timestamp; } set { timestamp = value; } }

        public Checklist()
        {

        }

        public Checklist(int id, bool isCompleted, byte[] timestamp)
        {
            Id = id;
            IsCompleted = isCompleted;
            Timestamp = timestamp;
        }
    }
}
