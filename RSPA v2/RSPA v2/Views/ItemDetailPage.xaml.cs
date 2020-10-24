using System.ComponentModel;
using Xamarin.Forms;
using RSPA_v2.ViewModels;

namespace RSPA_v2.Views
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