namespace GoogleGeocodingAPI
{
    /// <summary>
    /// Represent a latitude / longitude couple
    /// </summary>
    public class Geolocalisation
    {
        /// <summary>
        /// Represent the latitude.
        /// </summary>
        public double lat { get; set; }
        /// <summary>
        /// Represent the longitude.
        /// </summary>
        public double lng { get; set; }

        /// <summary>
        /// Converts the latitude / longitude values of this instance to its equivalent string representation.
        /// </summary>
        /// <returns>The string representation of this object.</returns>
        public override string ToString()
        {
            return lat.ToString() + "," + lng.ToString();
        }
    }
}
