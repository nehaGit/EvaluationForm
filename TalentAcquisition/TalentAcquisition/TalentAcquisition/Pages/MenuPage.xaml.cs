using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TalentAcquisition
{
	public partial class MenuPage : BaseContentPage
	{
		public ListView ListView { get { return listView; } }

		public MenuPage ()
		{
			InitializeComponent ();

			var masterPageItems = new List<MasterPageItem> ();
			masterPageItems.Add (new MasterPageItem {
				Title = "Home",
				IconSource = "home.png",
				TargetType = typeof(HomePage)
			});
			masterPageItems.Add (new MasterPageItem {
				Title = "Interview Form",
				IconSource = "interview.png",
				TargetType = typeof(InterviewForm)
			});
			masterPageItems.Add (new MasterPageItem {
				Title = "Evalution Form",
				IconSource = "evaluation.png",
				TargetType = typeof(SearchPage)
			});

			listView.ItemsSource = masterPageItems;
		}
	}
}