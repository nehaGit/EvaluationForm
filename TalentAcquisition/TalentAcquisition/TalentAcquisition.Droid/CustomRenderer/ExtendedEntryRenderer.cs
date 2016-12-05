using System;
using System.ComponentModel;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Graphics.Drawables.Shapes;
using Android.Text;
using Android.Text.Method;
using Android.Util;
using Android.Views;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Color = Xamarin.Forms.Color;
using TalentAcquisition;
using TalentAcquisition.Droid;

[assembly: ExportRenderer(typeof(ExtendedEntry), typeof(ExtendedEntryRenderer))]
namespace TalentAcquisition.Droid
{
	public class ExtendedEntryRenderer : EntryRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged(e);

			if (Control != null )
			{
				this.Control.Background = Resources.GetDrawable (Resource.Layout.CustomEntryDrawable );
			}
		
		}
	}
} 