using System;

using Xamarin.Forms;

namespace Astren_Empower.Models
{
    public class User : ContentPage
    {
        public User()
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

