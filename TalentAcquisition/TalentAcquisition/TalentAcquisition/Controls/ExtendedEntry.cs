using System;
using System.Runtime.CompilerServices;
using Xamarin.Forms;


[assembly: 
	InternalsVisibleTo("XLabs.Forms.Droid"),
	InternalsVisibleTo("XLabs.Forms.iOS"),
	InternalsVisibleTo("XLabs.Forms.WP8")]

namespace TalentAcquisition
{
	public class ExtendedEntry : Entry
	{
		public bool IsSingleLine { get; set;}
	}
}