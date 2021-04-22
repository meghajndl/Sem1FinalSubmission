using System;

using Xamarin.Forms;

namespace Astren_Empower.Services.Auth
{
    public class FakeAuthService : ContentPage
    {
        public FakeAuthService()
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

