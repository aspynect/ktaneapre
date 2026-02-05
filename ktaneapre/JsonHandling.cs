using System.Text.Json.Serialization;

namespace ktaneapre
{
    using System;
    using System.Collections.Generic;

    using System.Text.Json;
    using System.Text.Json.Serialization;
    using System.Globalization;

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