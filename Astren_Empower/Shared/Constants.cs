using System;

using Xamarin.Forms;

namespace Astren_Empower.Shared
{
    public class Constants : ContentPage
    {
        public Constants()
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

