using System.ComponentModel;
using Xamarin.Forms;
using DremovPR20.ViewModels;

namespace DremovPR20.Views
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