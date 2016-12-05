using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TalentAcquisition
{
	public partial class MainPage : MasterDetailPage
	{
		public MainPage ()
		{
			InitializeComponent ();
			menuPage.ListView.ItemSelected += OnItemSelected;
		}

		#region handle List Item Selection

		void OnItemSelected (object sender, SelectedItemChangedEventArgs e)
		{
			var item = e.SelectedItem as MasterPageItem;
			if (item != null) {
				Detail = new NavigationPage ((Page)Activator.CreateInstance (item.TargetType));
				menuPage.ListView.SelectedItem = null;
				IsPresented = false;
			}
		}
		#endregion

	}
}