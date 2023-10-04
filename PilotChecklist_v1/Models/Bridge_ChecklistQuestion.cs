using System;
using System.Collections.Generic;
using System.Text;

namespace PilotChecklist_v1.Models
{
    internal class Bridge_ChecklistQuestion
    {
        int checklistId;
        int questionId;

        public int ChecklistId { get { return checklistId; } set { checklistId = value; } }
        public int QuestionId { get { return questionId; } set { questionId = value; } }

        public Bridge_ChecklistQuestion()
        {

        }

        public Bridge_ChecklistQuestion(int checklistId, int questionId)
        {
            ChecklistId = checklistId;
            QuestionId = questionId;
        }
    }
}
