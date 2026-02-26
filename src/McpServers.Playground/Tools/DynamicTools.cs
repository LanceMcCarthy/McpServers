using ModelContextProtocol.Server;
using NodaTime;
using System.ComponentModel;
using System.Globalization;
using System.Text.Json;

namespace McpServers.Playground.Tools;

[McpToolType]
public static class DynamicTools
{
    [McpTool, Description("Gets the current date/time and location infor for the given lat,long coordinates (format: 'lat,long').")]
    public static string GetLatLongInfo(string coordinates)
    {
        if (string.IsNullOrWhiteSpace(coordinates))
            return "Invalid coordinates format. Use 'lat,long'.";

        var parts = coordinates.Split(',');

        if (parts.Length != 2 
            || !double.TryParse(parts[0], NumberStyles.Float, CultureInfo.InvariantCulture, out var lat) 
            || !double.TryParse(parts[1], NumberStyles.Float, CultureInfo.InvariantCulture, out var lng))
        {
            return "Invalid coordinates format. Use 'lat,long'.";
        }

        try
        {
            // Get location data

            using var response = new HttpClient().GetAsync($"https://api.geotimezone.com/public/timezone?latitude={lat}&longitude={lng}").Result;

            if (!response.IsSuccessStatusCode)
                return $"Failed to get timezone info: {response.StatusCode}";

            var json = response.Content.ReadAsStringAsync().Result;


            // Parse result

            using var doc = JsonDocument.Parse(json);

            if (!doc.RootElement.TryGetProperty("dst_abbreviation", out var tzIdProp) 
                || !doc.RootElement.TryGetProperty("iana_timezone", out var ianaProp) 
                || !doc.RootElement.TryGetProperty("location", out var locationProp))
                return "Could not determine timezone for coordinates.";

            var tzId = tzIdProp.GetString();
            var iana = ianaProp.GetString();
            var location = locationProp.GetString();

            if (string.IsNullOrEmpty(tzId) || string.IsNullOrEmpty(iana) || string.IsNullOrEmpty(location))
                return "Could not determine information for the provided coordinates.";


            // Use NodaTime

            var now = SystemClock.Instance.GetCurrentInstant();

            var tz = DateTimeZoneProviders.Tzdb.GetZoneOrNull(tzId);

            if (tz == null)
                return $"Timezone '{tzId}' not found in TZDB.";

            var zoned = now.InZone(tz);

            return $"The current date/time at {location} in {iana} timezone is ({lat}, {lng}) [{tzId}]: {zoned:yyyy-MM-dd HH:mm:ss z}.";
        }
        catch (Exception ex)
        {
            return $"Error: {ex.Message}";
        }
    }
}