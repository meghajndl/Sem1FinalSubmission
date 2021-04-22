using System;

using Xamarin.Forms;

namespace Astren_Empower.Models
{
    public class ServerAuth : ContentPage
    {
        public ServerAuth()
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

