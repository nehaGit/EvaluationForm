
using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using TalentAcquisition;
using TalentAcquisition.iOS;

namespace TalentAcquisition.iOS
{
	[assembly: ExportRenderer(typeof(ExtendedEntry), typeof(ExtendedEntryRenderer))]
	public class ExtendedEntryRenderer : EntryRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged (e);

			var view = e.NewElement as ExtendedEntry;

			if (view != null) {
			}
		}
	}
}

