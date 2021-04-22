using System;

using Xamarin.Forms;

namespace Astren_Empower.Models
{
    public class MenuListItem : ContentPage
    {
        public MenuListItem()
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

