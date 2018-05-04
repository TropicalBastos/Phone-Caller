using System;
using Xamarin.Forms;

namespace PhoneCaller.Controls
{
    public class TextView : Entry
    {

        public static readonly BindableProperty BorderColorProperty =
            BindableProperty.Create("BorderColor", typeof(Color),
                                    typeof(TextView), Color.Black);

        public Color BorderColor {
            get { return (Color)GetValue(BorderColorProperty); }
            set { SetValue(BorderColorProperty, value); }
        }

        public static readonly BindableProperty BorderWidthProperty =
            BindableProperty.Create("BorderWidth", 
                                    typeof(int), typeof(TextView), 1);

        public double BorderWidth {
            get { return (int)GetValue(BorderWidthProperty); }
            set { SetValue(BorderWidthProperty, value); }
        }

        public static readonly BindableProperty PaddingProperty =
            BindableProperty.Create("Padding", 
                                    typeof(int), typeof(TextView), 4);
        
        public double Padding{
            get { return (int)GetValue(PaddingProperty); }
            set { SetValue(PaddingProperty, value); }
        }

    }
}
