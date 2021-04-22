using System;

using Xamarin.Forms;

namespace Astren_Empower.Shared
{
    public class Settings : ContentPage
    {
        public Settings()
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

