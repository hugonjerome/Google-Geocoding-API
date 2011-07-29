using System.IO;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;
using System;

namespace GoogleGeocodingAPI
{
    /// <summary>
    /// Represent a geocoding request.
    /// </summary>
    public static class Request
    {
        /// <summary>
        /// The endpoint (HTTP) to the Google geocode API.
        /// </summary>
        private const string EndPoint = "http://maps.googleapis.com/maps/api/geocode/json?{0}";
        /// <summary>
        /// The secure endpoint (HTTPS) to the Google geocode API.
        /// </summary>
        private const string EndPointSecure = "https://maps.googleapis.com/maps/api/geocode/json?{0}";

        /// <summary>
        /// Send a request to te Google geocode API
        /// </summary>
        /// <param name="format">The format of the response</param>
        /// <param name="address">The address that you want to geocode.</param>
        /// <param name="latlong">The textual latitude/longitude value for which you wish to obtain the closest, human-readable address.</param>
        /// <param name="bounds">The bounding box of the viewport within which to bias geocode results more prominently.</param>
        /// <param name="region">The region code, specified as a ccTLD ("top-level domain") two-character value. More information: http://code.google.com/apis/maps/documentation/geocoding/#RegionCodes</param>
        /// <param name="language">The language in which to return results. More information: http://code.google.com/apis/maps/faq.html#languagesupport</param>
        /// <param name="sensor">Indicates whether or not the geocoding request comes from a device with a location sensor.</param>
        /// <param name="useHttps">HTTPS is recommended for applications that include sensitive user data, such as a user's location, in requests.</param>
        /// <returns>A response object that represent the response from Google geocode API.</returns>
        public static Response Send(
                    string address = null,
                    Geolocalisation latlong = null,
                    Boundlocalisation bounds = null,
                    string region = null,
                    string language = null,
                    bool sensor = false,
                    bool useHttps = false)
        {
            if (string.IsNullOrEmpty(address) && latlong == null)
            {
                throw new ApplicationException("Parameter missing: address and latlong are missing");
            }

            string parameters = string.Empty;
            parameters += !string.IsNullOrEmpty(address) ? "address=" + HttpUtility.UrlEncode(address) : "latlng=" + latlong.ToString();
            if (bounds != null) parameters += "&bounds=" + bounds.ToString();
            if (region != null) parameters += "&region=" + region;
            if (language != null) parameters += "&language=" + language;
            parameters += "&sensor=" + sensor.ToString().ToLower();

            string url = useHttps ? EndPointSecure : EndPoint;
            url = string.Format(url, parameters);

            WebRequest objRequest = HttpWebRequest.Create(url);
            StreamReader sr = new StreamReader(objRequest.GetResponse().GetResponseStream());

            JavaScriptSerializer jss = new JavaScriptSerializer();
            Response result = jss.Deserialize<Response>(sr.ReadToEnd());

            sr.Close();
            sr.Dispose();

            return result;
        }
    }
}
