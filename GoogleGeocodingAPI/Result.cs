using System.Collections.Generic;

namespace GoogleGeocodingAPI
{
    /// <summary>
    /// Represent a result.
    /// </summary>
    public class Result
    {
        /// <summary>
        /// List indicates the type of the returned result. This array contains a set of one or more tags identifying the type of feature returned in the result. For example, a geocode of "Chicago" returns "locality" which indicates that "Chicago" is a city, and also returns "political" which indicates it is a political entity.
        /// </summary>
        public List<AddressComponentType> types { get; set; }
        /// <summary>
        /// Is a string containing the human-readable address of this location. Often this address is equivalent to the "postal address," which sometimes differs from country to country. (Note that some countries, such as the United Kingdom, do not allow distribution of true postal addresses due to licensing restrictions.) This address is generally composed of one or more address components. For example, the address "111 8th Avenue, New York, NY" contains separate address components for "111" (the street number, "8th Avenue" (the route), "New York" (the city) and "NY" (the US state).
        /// </summary>
        public string formatted_address { get; set; }
        /// <summary>
        /// Is a list containing the separate address components. May contain more address components than noted within the FormattedAddress.
        /// </summary>
        public List<AddressComponent> address_components { get; set; }
        /// <summary>
        /// Contains geolocal information.
        /// </summary>
        public Geometry geometry { get; set; }
    }
}
