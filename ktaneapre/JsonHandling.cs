using System.Text.Json.Serialization;

namespace ktaneapre
{
    using System;
    using System.Collections.Generic;

    using System.Text.Json;
    using System.Text.Json.Serialization;
    using System.Globalization;
    using System.Runtime.CompilerServices;


    public static class JsonHandling
    {
        private static JsonRoot jsonData;
        public static JsonRoot Data => getData();

        public static JsonRoot getData()
        {
            if (jsonData is not null) return jsonData;
            return jsonData = loadData();
        }

        public static JsonRoot loadData()
        {
            string fileContents = File.ReadAllText(Path.Combine("profiles", $"{Profile.profileName}.json"));
            jsonData = JsonSerializer.Deserialize<JsonRoot>(fileContents)!;
            return jsonData;
        }

        public static void writeData()
        {
            if (Profile.profileName == "vanilla") return;
            string fileContents = JsonSerializer.Serialize<JsonRoot>(jsonData, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(Path.Combine("profiles", $"{Profile.profileName}.json"), fileContents);
        }
    }

    public partial class JsonRoot
    {
        [JsonPropertyName("wireseq")]
        public Wireseq Wireseq { get; set; }

        [JsonPropertyName("passwords")]
        public string[] Passwords { get; set; }

        [JsonPropertyName("knob")]
        public Dictionary<string, string> Knob { get; set; }
    }

    public partial class Wireseq
    {
        [JsonPropertyName("red")]
        public string[] Red { get; set; }

        [JsonPropertyName("blue")]
        public string[] Blue { get; set; }

        [JsonPropertyName("black")]
        public string[] Black { get; set; }
    }

    public partial class Simon
    {
        [JsonPropertyName("true")]
        public SimonColors True { get; set;  }

        [JsonPropertyName("false")]
        public SimonColors False { get; set; }
    }

    public partial class SimonColors
    {
        [JsonPropertyName("r")]
        public string Red { get; set; }

        [JsonPropertyName("b")]
        public string Blue { get; set; }

        [JsonPropertyName("g")]
        public string Green { get; set; }

        [JsonPropertyName("y")]
        public string Yellow { get; set; }
    }
}