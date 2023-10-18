using PilotChecklist.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace PilotChecklist_v1.Business
{
    class GlobalVariables
    {
        public static Pilot pilot;
        public static Flight flight;
        public static Checklist checklist;


        public static bool CheckIfChecklistComplete()
        {
            bool checklistComplete = true;

            if (checklist.IsCompleted != true)
            {
                checklistComplete = false;
            }

            return checklistComplete;
        }
    }
}
