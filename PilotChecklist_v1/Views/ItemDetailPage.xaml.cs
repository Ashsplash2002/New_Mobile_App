using PilotChecklist_v1.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace PilotChecklist_v1.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}