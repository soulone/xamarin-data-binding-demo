using System;

using Xamarin.Forms;

namespace Application
{
    public class ViewToViewDemo : ContentPage
    {
        public ViewToViewDemo()
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

