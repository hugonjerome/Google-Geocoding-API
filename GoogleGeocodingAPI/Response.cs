using System.Collections.Generic;

namespace GoogleGeocodingAPI
{
    /// <summary>
    /// Represent a geocoding response.
    /// </summary>
    public class Response
    {
        /// <summary>
        /// The status returned.
        /// </summary>
        public StatusCode status { get; set; }
        /// <summary>
        /// Represent the list of results.
        /// </summary>
        public List<Result> results { get; set; }
    }
}
