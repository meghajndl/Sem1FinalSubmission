using System;

using Xamarin.Forms;

namespace Astren_Empower.ViewModels.Base
{
    public class ViewModelBase : ContentPage
    {
        public ViewModelBase()
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

