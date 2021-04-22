using System;

using Xamarin.Forms;

namespace Astren_Empower.Models
{
    public class KEYS : ContentPage
    {
        public KEYS()
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

