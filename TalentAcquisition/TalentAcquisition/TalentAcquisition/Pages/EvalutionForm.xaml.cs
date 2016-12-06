using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TalentAcquisition
{
	public partial class EvalutionForm : BaseContentPage
	{
		public EvalutionForm ()
		{
			InitializeComponent ();
		}

		void OnTapingRecommendYes (object sender, EventArgs args)
		{
			imgRecommendNo.Source = "unchecked.png";
			imgRecommendYes.Source = "checked.png";
		}

		void OnTapingRecommendNo (object sender, EventArgs args)
		{
			imgRecommendYes.Source = "unchecked.png";
			imgRecommendNo.Source = "checked.png";
		}
		void OnTapTechRecommenYes (object sender, EventArgs args)
		{
			imgTechRecommendNo.Source = "unchecked.png";
			imgTechRecommendYes.Source = "checked.png";
		}

		void OnTapimgTechRecommenNo (object sender, EventArgs args)
		{
			imgTechRecommendYes.Source = "unchecked.png";
			imgTechRecommendNo.Source = "checked.png";
		}
	}
}

