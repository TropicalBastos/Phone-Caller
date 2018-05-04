using System;
using System.ComponentModel;
using CoreAnimation;
using CoreGraphics;
using PhoneCaller.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;


[assembly: ExportRenderer(typeof(TextView), typeof(PhoneCaller.iOS.TextViewRenderer))]
namespace PhoneCaller.iOS
{
    public class TextViewRenderer: EntryRenderer
    {
		protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
		{
            base.OnElementChanged(e);
            TextView textView = (TextView)this.Element;

            if(Control != null){
                Control.BorderStyle = UIKit.UITextBorderStyle.RoundedRect;
                Control.BackgroundColor = ((TextView)this.Element).BackgroundColor.ToUIColor();
            }
		}

	}
}
