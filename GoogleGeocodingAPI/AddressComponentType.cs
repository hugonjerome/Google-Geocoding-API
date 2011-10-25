namespace GoogleGeocodingAPI
{
    /// <summary>
    /// Reprsent the type of AddressComponent returned. The types may be considered "tags". For example, many cities are tagged with the Political and Locality type.
    /// </summary>
    public enum AddressComponentType
    {
        /// <summary>
        /// Indicates a precise street address. 
        /// </summary>
        street_address,
        /// <summary>
        /// Indicates a named route (such as "US 101").
        /// </summary>
        route,
        /// <summary>
        /// Indicates a major intersection, usually of two major roads.
        /// </summary>
        intersection,
        /// <summary>
        /// Indicates a political entity. Usually, this type indicates a polygon of some civil administration.
        /// </summary>
        political,
        /// <summary>
        /// Indicates the national political entity, and is typically the highest order type returned by the Geocoder.
        /// </summary>
        country,
        /// <summary>
        /// Indicates a first-order civil entity below the country level. Within the United States, these administrative levels are states. Not all nations exhibit these administrative levels.
        /// </summary>
        administrative_area_level_1,
        /// <summary>
        /// Indicates a second-order civil entity below the country level. Within the United States, these administrative levels are counties. Not all nations exhibit these administrative levels.
        /// </summary>
        administrative_area_level_2,
        /// <summary>
        /// Indicates a third-order civil entity below the country level. This type indicates a minor civil division. Not all nations exhibit these administrative levels.
        /// </summary>
        administrative_area_level_3,
        /// <summary>
        /// Indicates a commonly-used alternative name for the entity.
        /// </summary>
        colloquial_area,
        /// <summary>
        /// Indicates an incorporated city or town political entity.
        /// </summary>
        locality,
        /// <summary>
        /// Indicates an first-order civil entity below a locality.
        /// </summary>
        sublocality,
        /// <summary>
        /// Indicates a named neighborhood.
        /// </summary>
        neighborhood,
        /// <summary>
        /// Indicates a named location, usually a building or collection of buildings with a common name.
        /// </summary>
        premise,
        /// <summary>
        /// Indicates a first-order entity below a named location, usually a singular building within a collection of buildings with a common name.
        /// </summary>
        subpremise,
        /// <summary>
        /// Indicates a postal code as used to address postal mail within the country.
        /// </summary>
        postal_code,
        /// <summary>
        /// Indicates a prominent natural feature.
        /// </summary>
        natural_feature,
        /// <summary>
        /// Indicates an airport.
        /// </summary>
        airport,
        /// <summary>
        /// Indicates a named park.
        /// </summary>
        park,
        /// <summary>
        /// Indicates a named point of interest. Typically, these "POI"s are prominent local entities that don't easily fit in another category such as "Empire State Building" or "Statue of Liberty."
        /// </summary>
        point_of_interest,
        /// <summary>
        /// Indicates a specific postal box (only address components may exhibit this type).
        /// </summary>
        post_box,
        /// <summary>
        /// Indicates the precise street number (only address components may exhibit this type).
        /// </summary>
        street_number,
        /// <summary>
        /// Indicates the floor of a building address (only address components may exhibit this type).
        /// </summary>
        floor,
        /// <summary>
        /// Indicates the room of a building address (only address components may exhibit this type).
        /// </summary>
        room,
        /// <summary>
        /// Indicates an establishment.
        /// </summary>
        establishment,
        /// <summary>
        /// Indicates a train station.
        /// </summary>
        train_station,
        /// <summary>
        /// Indicates a parking.
        /// </summary>
        parking,
        /// <summary>
        /// Indicates a postal_code_prefix.
        /// </summary>
        postal_code_prefix,
        /// <summary>
        /// Indicates a postal_town.
        /// </summary>
        postal_town,
        /// <summary>
        /// Indicates a subway_station.
        /// </summary>
        subway_station
    }
}
