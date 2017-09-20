using Xamarin.Forms;

namespace RelativeReponsiveForms.Utils
{
    /// <summary>
    /// This class contains static members which are used in XAML files to position elements relatively.
    /// In XAML you can only use constants! Therefor it contains calculations for a number of "desired" measurements.
    /// If you need more specific measurements you need to add it as a static double member constant.
    /// </summary>
	public static class ScreenUtil
	{
        public static readonly IDisplay Display = DependencyService.Get<IDisplay>();

		public static readonly bool IsTablet = (Device.Idiom == TargetIdiom.Tablet);
		public static readonly double FontMultiplier = GetFontMultiplier();

		public static readonly double HOR1 = HorizontalPercent(1);
		public static readonly double HOR5 = HorizontalPercent(5);
		public static readonly double HOR10 = HorizontalPercent(10);
		public static readonly double HOR15 = HorizontalPercent(15);
		public static readonly double HOR20 = HorizontalPercent(20);
		public static readonly double HOR30 = HorizontalPercent(30);
		public static readonly double HOR50 = HorizontalPercent(50);

		public static readonly double VERT1 = VerticalPercent(1);
		public static readonly double VERT5 = VerticalPercent(5);
		public static readonly double VERT10 = VerticalPercent(10);
		public static readonly double VERT15 = VerticalPercent(15);
		public static readonly double VERT20 = VerticalPercent(20);
		public static readonly double VERT30 = VerticalPercent(30);
		public static readonly double VERT40 = VerticalPercent(40);
		public static readonly double VERT50 = VerticalPercent(50);

        public static readonly int VERT5I = (int)VerticalPercent(5);
        public static readonly int VERT10I = (int)VerticalPercent(10);
		public static readonly int VERT15I = (int)VerticalPercent(15);
		public static readonly int VERT20I = (int)VerticalPercent(20);
		public static readonly int VERT30I = (int)VerticalPercent(30);

        /// <summary>
        /// Static method which calculates the horizontal position (in points) according to the given percentage.
        /// </summary>
        /// <returns>Horizontal position (in points)</returns>
        /// <param name="percentage">Percentage.</param>
		static double HorizontalPercent(int percentage) {

			var caldulatedHorizonalPoints = (
                percentage
                * Display.WidthPoints()
                * 0.01
            );

			return caldulatedHorizonalPoints;
		}

		/// <summary>
		/// Static method which calculates the vertical position (in points) according to the given percentage.
		/// </summary>
		/// <returns>Vertical position (in points)</returns>
		/// <param name="percentage">Percentage.</param>
		static double VerticalPercent(int percentage) {
            var caldulatedVerticalPoints = (
                percentage
                * Display.HeightPoints()
                * 0.01
            );

			return caldulatedVerticalPoints;
		}

        /// <summary>
        /// Calculates a font multiplier which is used to change the font-size according to your needs.
        /// </summary>
        /// <returns>The font multiplier.</returns>
        static double GetFontMultiplier()
		{
			var fontMultiplier = Display.Scale();

            if (Device.RuntimePlatform == Device.iOS) {
                if (IsTablet)
                {
                    if (fontMultiplier <= 1.5d)
                    {
                        fontMultiplier += 1.5d;
                    }
                    else
                    {
                        fontMultiplier += 1d;
                    }
                }
                else {
					if (Display.HeightPoints() < 600)
					{
						fontMultiplier -= 0.5d;
					}
					else if (fontMultiplier > 2d)
					{
						fontMultiplier--;
					}
				}
            } else if (Device.RuntimePlatform == Device.Android) {
				if (IsTablet)
				{
					if (fontMultiplier <= 1.5d)
					{
						fontMultiplier += 1.5d;
					}
					else
					{
						fontMultiplier += 1d;
					}
				}
				// for phones
				else
				{
					if (fontMultiplier > 1.5d && fontMultiplier <= 3d)
					{
						fontMultiplier -= 1.2d;
					}
					else
					{
						fontMultiplier -= 1.6d;
					}
				}
			}

			return fontMultiplier;
		}
	}
}
