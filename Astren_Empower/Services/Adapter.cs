using System;

using Xamarin.Forms;

namespace Astren_Empower.Services
{
    public class Adapter : ContentPage
    {
        public Adapter()
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

