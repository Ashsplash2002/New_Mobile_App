using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace PilotChecklist_v1.ViewModels
{
    public class ChecklistViewModel : BaseViewModel
    {
        public ChecklistViewModel()
        {
            Title = "Checklist";
        }

        public ICommand OpenWebCommand { get; }
    }
}
