using System.Collections.Generic;

namespace GoogleGeocodingAPI
{
    /// <summary>
    /// Represent an address component.
    /// </summary>
    public class AddressComponent
    {
        /// <summary>
        /// Is an array indicating the type of the address component.
        /// </summary>
        public List<AddressComponentType> types { get; set; }
        /// <summary>
        /// Is the full text description or name of the address component as returned by the Geocoder.
        /// </summary>
        public string long_name { get; set; }
        /// <summary>
        /// Is an abbreviated textual name for the address component, if available. For example, an address component for the state of Alaska may have a LongName of "Alaska" and a ShortName of "AK" using the 2-letter postal abbreviation.
        /// </summary>
        public string short_name { get; set; }
    }
}
