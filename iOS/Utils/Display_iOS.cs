using RelativeReponsiveForms.iOS.Utils;
using RelativeReponsiveForms.Utils;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(Display_iOS))]

namespace RelativeReponsiveForms.iOS.Utils
{
    public class Display_iOS : IDisplay
    {
		double _heightPoints;
		double _widthPoints;
		double _scale;

        public Display_iOS() {
            using (var screen = UIScreen.MainScreen) {
				_scale = screen.Scale;
				_heightPoints = screen.Bounds.Height;
				_widthPoints = screen.Bounds.Width;
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
