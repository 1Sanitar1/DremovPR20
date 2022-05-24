using System;
using System.Collections.Generic;
using Xamarin.Forms;
using DremovPR20.ViewModels;
using DremovPR20.Views;

namespace DremovPR20
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(GetUserPage), typeof(GetUserPage));
            Routing.RegisterRoute(nameof(PostUserPage), typeof(PostUserPage));
            Routing.RegisterRoute(nameof(PutUserPage), typeof(PutUserPage));
            Routing.RegisterRoute(nameof(DeleteUserPage), typeof(DeleteUserPage));
        }

    }
}
