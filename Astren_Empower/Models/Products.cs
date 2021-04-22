using System;

using Xamarin.Forms;

namespace Astren_Empower.Models
{
    public class Faculty : ContentPage
    {
        public Faculty()
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

