using System;

using Xamarin.Forms;

namespace Astren_Empower.Models
{
    public class AuthSession : ContentPage
    {
        public AuthSession()
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

