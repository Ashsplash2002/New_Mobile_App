using System;
using System.Collections.Generic;
using System.Text;

namespace PilotChecklist_v1.Models
{
    internal class Question
    {
        int id;
        string question;
        List<string> notes;
        bool isChecked;

        public int Id { get { return id; } set { id = value; } }
        public string _Question { get { return question; } set { question = value; } }
        public List<string> Notes { get { return notes; } set { notes = value; } }
        public bool IsChecked { get { return isChecked; } set { isChecked = value; } }

        public Question()
        {

        }

        public Question(int id, string question, List<string> notes, bool isChecked)
        {
            Id = id;
            string _Question = question;
            Notes = notes;
            IsChecked = isChecked;
        }
    }
}
