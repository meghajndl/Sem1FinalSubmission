using System;

using Xamarin.Forms;

namespace Astren_Empower.Services.Auth
{
    public class IAuthService : ContentPage
    {
        public IAuthService()
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

