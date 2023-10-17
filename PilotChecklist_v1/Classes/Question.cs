using System;
using System.Collections.Generic;
using System.Text;

namespace PilotChecklist.Classes
{
    internal class Question
    {
        int id;
        string item;
        bool isChecked;
        byte[] timestamp;

        public int Id { get { return id; } set {  id = value; } }
        public string Item { get { return item; } set { item = value; } }
        public bool IsChecked { get {  return isChecked; } set {  isChecked = value; } }
        public byte[] Timestamp { get { return timestamp; } set { timestamp = value; } }

        public Question()
        {

        }

        public Question(int id, string item, bool isChecked, byte[] timestamp)
        {
            Id = id;
            Item = item;
            IsChecked = isChecked;
            Timestamp = timestamp;
        }
    }
}
