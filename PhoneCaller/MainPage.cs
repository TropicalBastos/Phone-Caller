using System;
using Xamarin.Forms;
using PhoneCaller.Controls;
using PhoneCaller.Interfaces;
using System.Threading.Tasks;

namespace PhoneCaller
{
    public class MainPage: ContentPage
    {

        StackLayout _Layout { get; set; }
        Label _Label { get; set; }
        Button _Submit { get; set; }
        TextView _TextView { get; set; }

        public MainPage()
        {
            BackgroundColor = Color.Turquoise;

            _Layout = new StackLayout()
            {
                Spacing = 20,
                Padding = 20,
                VerticalOptions = LayoutOptions.Center
            };

            _TextView = new TextView()
            {
                BorderColor = Color.Black,
                WidthRequest = 300,
                HeightRequest = 50,
                Padding = 20,
                BorderWidth = 40,
                BackgroundColor = Color.White,
                Keyboard = Keyboard.Telephone
            };

            //System.Diagnostics.Debug.WriteLine(textView.Padding);

            SubmitButton submitButtonView = new SubmitButton();
            _Submit = submitButtonView.FindByName<Button>("button");
            _Submit.Clicked += SubmitClicked;

            _Label = new Label
            {
                Text = "PHONE CALLER",
                FontSize = 44,
                HorizontalOptions = LayoutOptions.Center
            };

            _Layout.Children.Add(_Label);
            _Layout.Children.Add(_TextView);
            _Layout.Children.Add(submitButtonView);
            this.Content = _Layout;
        }

        private void SubmitClicked(object sender, EventArgs args)
        {
            _Submit.Text = "CALLING...";
            string phoneNumber = _TextView.Text;
            DependencyService.Get<IPhoneCall>().MakePhoneCall(phoneNumber);
            #pragma warning disable CS4014 // ASYNC
            finishCalling(3000);
            #pragma warning restore CS4014
        }

        private void resetCallButton()
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                _Submit.Text = "CALL";
            });
        }

        private async Task<int> finishCalling(int delay)
        {
            await Task.Delay(delay);
            await Task.Run(() => resetCallButton());
            return 0;
        }

    }

}
