﻿namespace GoogleGeocodingAPI
{
    /// <summary>
    /// Represent an additional data about the specified location.
    /// </summary>
    public enum LocationType
    {
        /// <summary>
        /// Indicates that the returned result is a precise geocode for which we have location information accurate down to street address precision.
        /// </summary>
        RoofTop,
        /// <summary>
        /// Indicates that the returned result reflects an approximation (usually on a road) interpolated between two precise points (such as intersections). Interpolated results are generally returned when rooftop geocodes are unavailable for a street address.
        /// </summary>
        RangeInterpolated,
        /// <summary>
        /// Indicates that the returned result is the geometric center of a result such as a polyline (for example, a street) or polygon (region).
        /// </summary>
        GeometricCenter,
        /// <summary>
        /// Indicates that the returned result is approximate.
        /// </summary>
        Approximate
    }
}
