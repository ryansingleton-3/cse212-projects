public class FeatureCollection {
    public string Type { get; set; }
    public Feature[] Features { get; set; }

    public string GetEarthquakes() {
        string result = "";
        foreach (var feature in Features) {
            result += $"{feature.Properties.Place}, Mag {feature.Properties.mag}\n";
        }
        return result.Trim();
    }
}

public class Feature {
    public Properties Properties { get; set; }
}

public class Properties {
    public float mag { get; set; }
    public string Place { get; set; }
}
