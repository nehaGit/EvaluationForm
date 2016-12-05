
using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using UIKit;
using Xamarin.Forms.Platform.iOS;
using TalentAcquisition;
using TalentAcquisition.iOS;
using Xamarin.Forms;
using CoreAnimation;

[assembly: ExportRenderer(typeof(ExtendedEntry), typeof(ExtendedEntryRenderer))]

namespace TalentAcquisition.iOS
{
	public class ExtendedEntryRenderer : EntryRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged(e);

			Control.BorderStyle = UITextBorderStyle.None;
			if(e.NewElement!=null)
			e.NewElement.SizeChanged += NewElementOnSizeChanged;
		}
		private void NewElementOnSizeChanged(object sender, EventArgs eventArgs)
		{
			var blurredImage = sender as ExtendedEntry;
			if (blurredImage != null)
			{
				var width = blurredImage.Width;
				var height = blurredImage.Height;

				var view = Element as ExtendedEntry;

				if (view != null)
				{
					if (view.IsSingleLine == true)
					{
						var borderLayer = new CALayer();
						borderLayer.MasksToBounds = true;
						borderLayer.Frame = new CGRect(0f, Frame.Height / 2, width, 1f);
						borderLayer.BorderColor = UIColor.Black.CGColor;
						borderLayer.BorderWidth = 1.0f;

						Control.Layer.AddSublayer(borderLayer);
						Control.BorderStyle = UITextBorderStyle.None;
					}


				}
			}
		}

		protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			
		}

	
	}
}

