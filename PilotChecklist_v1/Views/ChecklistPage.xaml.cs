using PilotChecklist.Classes;
using PilotChecklist_v1.Business;
using PilotChecklist_v1.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        UpdateOperations updateOps = new UpdateOperations();
        private List<Question> checklistItems = new List<Question>();
        private List<Question> temp_checklistItems = new List<Question>();

        public ChecklistPage()
        {
            InitializeComponent();
            InitializeQuestions();
        }

        private void InitializeQuestions()
        {
            checklistItems = GetQuestions();
            ChecklistCollectionView.ItemsSource = checklistItems;

            BindingContext = this;
        }

        private List<Question> GetQuestions()
        {
            return selectOps.SelectQuestions();
        }

        private void Checkbox_Changed(object sender, CheckedChangedEventArgs e)
        {
            var checkbox = (CheckBox)sender;
            var checklistItem = (Question)checkbox.BindingContext;

            if (checklistItem != null)
            {
                checklistItem.IsChecked = e.Value;

                // Check if the item is already in the list
                if (checklistItems.Contains(checklistItem))
                {
                    checklistItems.Remove(checklistItem); // Remove it
                }

                checklistItems.Add(checklistItem); // Add the updated item
            }
        }

        private void Save_Clicked(object sender, EventArgs e)
        {
            updateOps.Update_Questions(checklistItems);
            updateOps.Update_Checklist(GlobalVariables.checklist.Id, GlobalVariables.CheckIfChecklistComplete());
            Navigation.PopAsync();
        }

        private void CheckAllCheckboxes()
        {
            foreach (var item in checklistItems)
            {
                item.IsChecked = true;
            }

            ChecklistCollectionView.ItemsSource = temp_checklistItems;
            ChecklistCollectionView.ItemsSource = checklistItems;
        }

        private void CheckAll_Clicked(object sender, EventArgs e)
        {
            CheckAllCheckboxes();
        }

        private void UncheckAllCheckboxes()
        {
            foreach (var item in checklistItems)
            {
                item.IsChecked = false;
            }

            ChecklistCollectionView.ItemsSource = temp_checklistItems;
            ChecklistCollectionView.ItemsSource = checklistItems;
        }

        private void UncheckAll_Clicked(object sender, EventArgs e)
        {
            UncheckAllCheckboxes();
        }

        private async void FinishChecklist()
        {
            bool allChecked = true;

            foreach (var item in checklistItems)
            {
                if (!item.IsChecked)
                {
                    allChecked = false;
                    break;
                }
            }

            if (allChecked)
            {
                updateOps.Update_Checklist(GlobalVariables.checklist.Id, true);
                updateOps.Update_Questions(checklistItems);

                GlobalVariables.checklist = selectOps.SelectChecklist_ById(GlobalVariables.checklist.Id)[0];

                await Navigation.PopAsync();
            }
            else
            {
                updateOps.Update_Checklist(GlobalVariables.checklist.Id, false);
                GlobalVariables.checklist = selectOps.SelectChecklist_ById(GlobalVariables.checklist.Id)[0];
                await App.Current.MainPage.DisplayAlert("Checklist Incomplete", "Make sure all items are checked.", "OK");
            }
        }

        private void FinishChecklist_Clicked(object sender, EventArgs e)
        {
            FinishChecklist();
        }
    }
}