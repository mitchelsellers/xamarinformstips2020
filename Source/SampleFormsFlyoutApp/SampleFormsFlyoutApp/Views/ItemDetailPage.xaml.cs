using SampleFormsFlyoutApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace SampleFormsFlyoutApp.Views
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