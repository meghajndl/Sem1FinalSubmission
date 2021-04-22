using System;

using Xamarin.Forms;

namespace Astren_Empower.Services.Auth
{
    public class AwsAuthService : ContentPage
    {
        public AwsAuthService()
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

