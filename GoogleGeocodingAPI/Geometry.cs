namespace GoogleGeocodingAPI
{
    /// <summary>
    /// Represent geolocal information.
    /// </summary>
    public class Geometry
    {
        /// <summary>
        /// Contains the geocoded latitude,longitude value. For normal address lookups, this field is typically the most important.
        /// </summary>
        public Geolocalisation location { get; set; }
        /// <summary>
        /// Stores additional data about the specified location.
        /// </summary>
        public LocationType location_type { get; set; }
        /// <summary>
        /// Contains the recommended viewport for displaying the returned result, specified as two latitude,longitude values defining the southwest and northeast corner of the viewport bounding box. Generally the viewport is used to frame a result when displaying it to a user.
        /// </summary>
        public Boundlocalisation viewport { get; set; }
        /// <summary>
        /// (optionally returned) stores the bounding box which can fully contain the returned result. Note that these bounds may not match the recommended viewport. (For example, San Francisco includes the Farallon islands, which are technically part of the city, but probably should not be returned in the viewport.)
        /// </summary>
        public Boundlocalisation bounds { get; set; }
    }
}
