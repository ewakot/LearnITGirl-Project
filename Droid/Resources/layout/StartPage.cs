using System;

using Xamarin.Forms;

namespace DriverTracker.Droid
{
	public class StartPage : ContentPage
	{
		public StartPage ()
		{
			Content = new StackLayout { 
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}


