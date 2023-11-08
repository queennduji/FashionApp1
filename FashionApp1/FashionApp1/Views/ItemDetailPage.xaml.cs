using System.ComponentModel;
using Xamarin.Forms;
using FashionApp1.ViewModels;

namespace FashionApp1.Views
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
