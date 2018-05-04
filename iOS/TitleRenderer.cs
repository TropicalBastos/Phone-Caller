using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using PhoneCaller.iOS;
using UIKit;

[assembly: ExportRenderer(typeof(Label), typeof(TitleRenderer))]
namespace PhoneCaller.iOS
{
    public class TitleRenderer : LabelRenderer
    {

		protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
		{
            base.OnElementChanged(e);

            Label label = Element;

            if(Control != null){
                Control.Font = UIFont.FromName("Anton-Regular", (nfloat)label.FontSize);
            }
		}

	}
}
