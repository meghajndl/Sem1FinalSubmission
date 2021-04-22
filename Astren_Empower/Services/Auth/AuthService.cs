using System;

using Xamarin.Forms;

namespace Astren_Empower.Services.Auth
{
    public class AuthService : ContentPage
    {
        public AuthService()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

