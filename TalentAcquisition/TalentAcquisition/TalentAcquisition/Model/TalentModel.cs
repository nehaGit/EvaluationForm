using System;

namespace TalentAcquisition
{
	public class Interviewee
	{
		public int ID{ get; set; }

		public string FisrtName { get; set; }

		public string LastName { get; set; }

		public string FatherorSpouse { get; set;}

		public string PermanentAddress { get; set; }

		public string Email { get; set; }

		public string SkypeID { get; set; }

		public int Mobile { get; set; } 

		public string Landline { get; set; }

		public string PassportNo { get; set; }

		public string ValidVisa { get; set; }

		public string IDType { get; set; }

		public string IDNo { get; set; }

		public string PositionType { get; set; }

		public string Image { get; set; }

		public string Sex { get; set; }

		public string MartialStatus { get; set; }

		public string Nationality { get; set; }

		public string BirthPlace { get; set; }

		public string DOB { get; set; }

		public string isSurgery { get; set; }

		public string IsCriminalRecord { get; set; }

		public bool IsAnyoneWorkinginIcreon { get; set; }

		public string IcreonReferenceName { get; set; }

	}


	public class FamilyHistory 
	{
		public int ID { get; set; }

		public int IntervieweeID { get; set; }

		public string Name { get; set; }

		public string Relation { get; set; }

		public string Occupation { get; set; }

		public string Dependent { get; set; }

	}

	public class References 
	{
		public int ID { get; set; }

		public int IntervieweeID { get; set; }

		public string Designation { get; set; }

		public string Employer { get; set; }

		public int Contact { get; set; }
	}

	public class TechnicalSkills 
	{
		public int ID { get; set; }

		public int IntervieweeID { get; set; }

		public string Expertise { get; set; }

		public string TechCertification { get; set; }

		public int CertificationYear { get; set; }

		public int Contact { get; set; }
	}

	public class EmploymentHistory 
	{
		public int ID { get; set; }

		public int IntervieweeID { get; set; }

		public int DurationFrom { get; set; }

		public int DurationTo { get; set; }

		public int TotalDuration { get; set; }

		public string NameAddress { get; set; }

		public string DesginationOnLeaving { get; set; }

		public string DesginationOnJoining { get; set; }

		public string Reason { get; set; }
	}

	public class EducationalHistory 
	{
		public int ID { get; set; }

		public int IntervieweeID { get; set; }

		public int YearFrom { get; set; }

		public int YearTo { get; set; }

		public string Course { get; set; }

		public string School { get; set; }

		public int Marks { get; set; }

	}

	public class Languages 
	{
		public int ID { get; set; }

		public int IntervieweeID { get; set; }

		public string Name { get; set; }

		public string Speak { get; set; }

		public string Read { get; set; }

		public string Write { get; set; }

	}

	public class Evaluation 
	{
		public int ID { get; set; }

		public int IntervieweeID { get; set; }

		public string TestGiven { get; set; }

		public string Score { get; set; }

		public bool RecruiterRecommendation { get; set; }

		public string RecruiterComment { get; set; }

		public bool TechRecommendation { get; set; }

		public string TechComment { get; set; }

		public float currentCTC { get; set; }

		public float ExpectedCTC { get; set; }

		public string ExpectedCTCRange { get; set; }

		public float OfferredCTC { get; set; }

		public string NP { get; set; }

		public string OtherDepRecommendation { get; set; }

		public string VendorCost { get; set; }

		public string VendorName { get; set; }

		public string OtherOfferConditions { get; set; }

		public string ReportingManager { get; set; }

		public string Location { get; set; }

		public string Recruiter { get; set; }

		public string ProfileSource { get; set; }

		public string TechPanelName { get; set; }

		public string CommitmentAmount { get; set; }

		public string LTA { get; set; }

		public string Medical { get; set; }

		public string FoodCoupon { get; set; }

		public string GiftCoupon { get; set; }

		public string ESI { get; set; }

		public string Relocation { get; set; }

		public string AnyOtherCommitment { get; set; }

		public string DOJ { get; set; }

		public string PF { get; set; }

		public string SalaryReviewMonth { get; set; }

		public string PBIReviewMonth { get; set; }

		public string PBI { get; set; }

		public string GrossSalary { get; set; }

		public string Department { get; set; }

		public string Designation { get; set; }
	}

	public class TechEvaluation 
	{
		public int ID { get; set; }

		public int EvaluationID { get; set; }

		public string EvaluationParameter { get; set; }

		public int Panel1Rate { get; set; }

		public int Panel2Rate { get; set; }

	}

	public class SkillsEvaluation 
	{
		public int ID { get; set; }

		public int EvaluationID { get; set; }

		public string SkillName { get; set; }

		public string TechPanel { get; set; }

		public string FinalPanel { get; set; }

		public string HR { get; set; }

	}
}

