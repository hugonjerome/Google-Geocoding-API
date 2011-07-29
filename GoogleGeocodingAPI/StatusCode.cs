﻿namespace GoogleGeocodingAPI
{
    /// <summary>
    /// The "status" field within the Geocoding response object contains the status of the request, and may contain debugging information to help you track down why Geocoding is not working.
    /// </summary>
    public enum StatusCode
    {
        /// <summary>
        /// Indicates that no errors occurred; the address was successfully parsed and at least one geocode was returned.
        /// </summary>
        OK,
        /// <summary>
        /// Indicates that the geocode was successful but returned no results. This may occur if the geocode was passed a non-existent address or a latlng in a remote location.
        /// </summary>
        ZERO_RESULTS,
        /// <summary>
        /// Indicates that you are over your quota.
        /// </summary>
        OVER_QUERY_LIMIT,
        /// <summary>
        /// Indicates that your request was denied, generally because of lack of a sensor parameter.
        /// </summary>
        REQUEST_DENIED,
        /// <summary>
        /// Generally indicates that the query (address or latlng) is missing.
        /// </summary>
        INVALID_REQUEST
    }
}
