using System;

using Xamarin.Forms;

namespace TalentAcquisition
{
	public partial class BaseContentPage : ContentPage
	{
		public BaseViewModel ViewModel { get { return BindingContext as BaseViewModel; } }
		protected override void OnAppearing()
		{
			base.OnAppearing();
			if (ViewModel != null)
				ViewModel.OnAppear();
		}
		protected override void OnDisappearing()
		{
			base.OnDisappearing();
			if (ViewModel != null)
				ViewModel.OnDisappear();
		}
	}
}