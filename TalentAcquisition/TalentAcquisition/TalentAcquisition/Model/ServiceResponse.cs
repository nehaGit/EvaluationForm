using System;
using System.Collections.Generic;

namespace TalentAcquisition
{
	public class IntervieweeResponse
	{
		public Interviewee interviewee{ get; set;}

		public List<EducationalHistory> eduHistory { get; set;}

		public List<FamilyHistory> familyHistory { get; set;}

		public List<References> rerences { get; set;}

		public List<EmploymentHistory> empHistory { get; set;}

		public List<TechnicalSkills> techSkills { get; set;}

		public List<Languages> languages { get; set;}
	}
}

