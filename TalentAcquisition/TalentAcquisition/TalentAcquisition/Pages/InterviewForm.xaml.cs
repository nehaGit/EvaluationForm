using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TalentAcquisition
{
	public partial class InterviewForm : ContentPage
	{
		public InterviewForm ()
		{
			InitializeComponent ();
		}
		#region Handle Image Tap

		void OnTapimgRelationYes (object sender, EventArgs args)
		{
			imgRelationNo.Source = "unchecked.png";
			imgRelationYes.Source = "checked.png";
		}

		void OnTapimgRelationNo (object sender, EventArgs args)
		{
			imgRelationYes.Source = "unchecked.png";
			imgRelationNo.Source = "checked.png";
		}
		void OnTapimgillnessYes (object sender, EventArgs args)
		{
			imgillnessNo.Source = "unchecked.png";
			imgillnessYes.Source = "checked.png";
		}

		void OnTapimgillnessNo (object sender, EventArgs args)
		{
			imgillnessYes.Source = "unchecked.png";
			imgillnessNo.Source = "checked.png";
		}
		void OnTapimgCrimeYes (object sender, EventArgs args)
		{
			imgCrimeNo.Source = "unchecked.png";
			imgCrimeYes.Source = "checked.png";
		}

		void OnTapimgCrimeNo (object sender, EventArgs args)
		{
			imgCrimeYes.Source = "unchecked.png";
			imgCrimeNo.Source = "checked.png";
		}
		#endregion
	}
}