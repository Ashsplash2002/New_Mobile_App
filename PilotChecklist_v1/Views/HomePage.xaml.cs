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

            FlightListView.ItemsSource = GetFlightData();
        }

        private List<Flight> GetFlightData()
        {
            return selectOps.SelectFlight_ById(GlobalVariables.pilot.FlightId);

        }
    }
}