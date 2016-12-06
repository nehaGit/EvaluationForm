using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace TalentAcquisition
{
	public class IntervieweeModel : BaseViewModel
	{
		public IntervieweeModel(INavigation navigation)
		{
			Navigation = navigation;
		}

		private Interviewee _intervieweeDetail;
		public Interviewee IntervieweeDetail
		{
			get { return _intervieweeDetail; }
			set { _intervieweeDetail = OnDetailInterviewee(); OnPropertyChanged(); }
		}

		private List<Interviewee> _intervieweeList;
		public List<Interviewee> IntervieweeList
		{
			get { return _intervieweeList; }
			set { _intervieweeList = OnIntervieweeList(); OnPropertyChanged(); }
		}

		#region Methods

		#region Commands

		public ICommand AddIntervieweeCommand { get { return new Command(async () => await RunSafe(OnInterviewee)); } }

		public ICommand SearchCommand { get { return new Command(async () => await RunSafe(onSearch)); } }

			
		#endregion

		Interviewee OnDetailInterviewee()
		{
			Interviewee patient = new Interviewee();

			return patient;
		}

		List<Interviewee> OnIntervieweeList()
		{
			List<Interviewee> intervieweeList = new List<Interviewee>()
			{
				new Interviewee(){FirstName="Avinash", LastName="Garg", PositionType="Xamarin Developer", Image="user.png",Mobile=9809876548,Email="avi@gmail.com"},
					new Interviewee(){FirstName="Karan", LastName="Veer", PositionType="PHP Developer", Image="user.png",Mobile=9649080999,Email="karan@gmail.com"},
					new Interviewee(){FirstName="Mayank", LastName="Jain", PositionType=".Net Developer", Image="user.png",Mobile=8798718907,Email="mayank@gmail.com"},
				new Interviewee(){FirstName="Naresh", LastName="Bahl", PositionType="Testing", Image="user.png",Mobile=9809876548,Email="naresh@gmail.com"},
					new Interviewee(){FirstName="Neelam", LastName="Sharma", PositionType="Xamarin Developer", Image="user.png",Mobile=9809977098,Email="neel@gmail.com"},
					new Interviewee(){FirstName="Sidhant", LastName="Singh", PositionType="iOS Developer", Image="user.png",Mobile=8969945320,Email="sid@gmail.com"},
					new Interviewee(){FirstName="Seema", LastName="Rajput", PositionType="Android Developer", Image="user.png",Mobile=7896577990,Email="seema98@gmail.com"},
			};
			return intervieweeList;
		}

		void onSearch()
		{
			
		}

		void OnInterviewee()
		{
		}

		public override void OnDisappear()
		{
			IntervieweeDetail = null;
		}

		public override void OnAppear()
		{
			base.OnAppear();
			IntervieweeDetail = new Interviewee();
			IntervieweeList = new List<Interviewee>();
		}



		#endregion
	}
}