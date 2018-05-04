using System;
using Foundation;
using PhoneCaller.Interfaces;
using PhoneCaller.iOS;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(PhoneCall_iOS))]
namespace PhoneCaller.iOS
{
    public class PhoneCall_iOS : IPhoneCall
    {

        public void MakePhoneCall(String phoneNumber)
        {
            Console.WriteLine("Calling: {0}", phoneNumber);

            try
            {
                string urlString = String.Format("tel://{0}", phoneNumber);
                NSUrl url = new NSUrl(urlString);
                UIApplication.SharedApplication.OpenUrl(url, new NSDictionary(), null);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }

    }
}
