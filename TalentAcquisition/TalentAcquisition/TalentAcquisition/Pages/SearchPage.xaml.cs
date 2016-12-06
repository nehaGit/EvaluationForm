using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace TalentAcquisition
{
	public partial class SearchPage : BaseContentPage
	{
		List<Interviewee> interviewList;
		public IntervieweeModel ViewModel {get	{return BindingContext as IntervieweeModel;}}
		public SearchPage()
		{
			InitializeComponent();

			BindingContext = new IntervieweeModel(this.Navigation);
		
			IntervieweelistView.ItemSelected += OnItemSelected;
		}

		#region handle List Item Selection

		void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var item = e.SelectedItem as Interviewee;
			if (item != null)
			{
				Navigation.PushAsync(new EvalutionForm());
			}
		}

		private void SearchBar_OnTextChanged(object sender, TextChangedEventArgs e)
		{
			if (interviewList == null)
			{
				dynamic c = BindingContext;
				if (c != null)
				{
					interviewList = c.IntervieweeList;
				}
			}

			if (string.IsNullOrWhiteSpace(e.NewTextValue))
				IntervieweelistView.ItemsSource = interviewList;
			else if(interviewList!=null){
				IntervieweelistView.ItemsSource = interviewList.Where(i => i.FirstName.Contains(e.NewTextValue.ToLower()) || i.LastName.Contains(e.NewTextValue.ToLower()));
			}
			//IntervieweelistView.EndRefresh();
		}
		#endregion
	}
}
