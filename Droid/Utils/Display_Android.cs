using Android.Content;
using Android.Runtime;
using Android.Util;
using Android.Views;
using RelativeReponsiveForms.Droid.Utils;
using RelativeReponsiveForms.Utils;
using Xamarin.Forms;

[assembly: Dependency(typeof(Display_Android))]

namespace RelativeReponsiveForms.Droid.Utils
{
    public class Display_Android : IDisplay
    {
        double _heightPoints;
        double _widthPoints;
        double _scale;

        public Display_Android() {
            var context = global::Android.App.Application.Context;
            using (var windowManager = context.GetSystemService(Context.WindowService).JavaCast<IWindowManager>())
            using (var display = windowManager.DefaultDisplay) {
                DisplayMetrics metrics = new DisplayMetrics();
                display.GetMetrics(metrics);

                try
                {
                    _scale = metrics.ScaledDensity;
                    _heightPoints = metrics.HeightPixels / _scale;
                    _widthPoints = metrics.WidthPixels / _scale;
				}
                finally
                {
                    if (metrics != null) {
                        metrics.Dispose();
                    }
                }
                    
            }
        }

        public double HeightPoints()
        {
            return _heightPoints;
        }

        public double Scale()
        {
            return _scale;
		}

        public double WidthPoints()
        {
            return _widthPoints;
		}
    }
}
