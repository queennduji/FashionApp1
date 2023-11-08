using System;
using System.Collections.Generic;
using FashionApp1.ViewModels;
using FashionApp1.Views;
using Xamarin.Forms;

namespace FashionApp1
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}

