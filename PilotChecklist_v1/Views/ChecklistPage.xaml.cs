using PilotChecklist.Classes;
using PilotChecklist_v1.Business;
using PilotChecklist_v1.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PilotChecklist_v1.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ChecklistPage : ContentPage
	{
		SelectOperations selectOps = new SelectOperations();

		public ChecklistPage ()
		{
			InitializeComponent();
			
		}

		private List<Checklist> GetChecklist()
		{
			return selectOps.SelectChecklist_ById(GlobalVariables.flight.ChecklistId);
		}
	}
}