using System.Linq;
using Xamarin.Forms;
using RelativeReponsiveForms.Views;
using RelativeReponsiveForms.Utils;
using System;

namespace RelativeReponsiveForms
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            if (Device.RuntimePlatform == Device.iOS)
            {
                MainPage = new FirstPage();
            }
            else
            {
                MainPage = new NavigationPage(new FirstPage());
            }

            SetUpFontSizes();
        }

        void SetUpFontSizes()
		{
			var keys = Current.Resources.Keys.Where(k => k.StartsWith("FontSize", StringComparison.OrdinalIgnoreCase));

			// have to use old-style for-loop otherwise will get a runtime exception indicating that the collection has changed!
			for (int i = 0; i < keys.Count(); i++)
			{
				var key = keys.ElementAt(i);
				double value;

                try
				{
					value = (double)Current.Resources[key];
				}
				catch (InvalidCastException)
				{
					// the other type of this value would be OnPlatform, so try that one
					value = (OnPlatform<double>)Current.Resources[key];
				}

				Current.Resources[key] = value * ScreenUtil.FontMultiplier;
			}
		}
	}
}
