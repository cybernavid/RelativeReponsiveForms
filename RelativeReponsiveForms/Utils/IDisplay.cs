namespace RelativeReponsiveForms.Utils
{
    /// <summary>
    /// This interface has to be implemented by platform specific implementations which provide display information.
    /// </summary>
    public interface IDisplay
    {
        /// <summary>
        /// Returns the display's scale which is actually number of pixels per point.
        /// </summary>
        /// <returns>The scale.</returns>
        double Scale();

        /// <summary>
        /// Width of the display in points.
        /// </summary>
        /// <returns>Number of points.</returns>
        double WidthPoints();

		/// <summary>
		/// Height of the display in points.
		/// </summary>
		/// <returns>Number of points.</returns>
		double HeightPoints();
    }
}