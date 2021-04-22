using System;

using Xamarin.Forms;

namespace Astren_Empower.Models
{
    public class GenericServiceResponse : ContentPage
    {
        public GenericServiceResponse()
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

