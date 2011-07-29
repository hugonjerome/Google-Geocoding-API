namespace GoogleGeocodingAPI
{
    /// <summary>
    /// Represent a geolocal box.
    /// </summary>
    public class Boundlocalisation
    {
        /// <summary>
        /// Represent the south west point of the box
        /// </summary>
        public Geolocalisation southwest { get; set; }
        /// <summary>
        /// Represent the north east point of the box
        /// </summary>
        public Geolocalisation northeast { get; set; }

        /// <summary>
        /// Converts the geolocal values of this instance to its equivalent string representation.
        /// </summary>
        /// <returns>The string representation of this object.</returns>
        public override string ToString()
        {
            return southwest.ToString() + "|" + northeast.ToString();
        }
    }
}
