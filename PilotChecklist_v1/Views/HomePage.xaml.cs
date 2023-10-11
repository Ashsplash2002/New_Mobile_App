using PilotChecklist_v1.Business;
using PilotChecklist_v1.DataAccess;
using PilotChecklist.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PilotChecklist_v1.Views
{
    public partial class HomePage : ContentPage
    {
        SelectOperations selectOps = new SelectOperations();

        public HomePage()
        {
            InitializeComponent();

            FlightList.ItemsSource = GetFlightData();
        }

        private List<Flight> GetFlightData()
        {
            GlobalVariables.flight = selectOps.SelectFlight_ById(GlobalVariables.pilot.FlightId)[0];

            return selectOps.SelectFlight_ById(GlobalVariables.pilot.FlightId);

        }

        private async void OnViewChecklistClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ChecklistPage());
        }
    }
}