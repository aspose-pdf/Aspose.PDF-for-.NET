using System.Text.Json.Serialization;

namespace Aspose.Pdf.Translate.Helper
{
    public class TranslationRequest
    {
        [JsonPropertyName("sourceLanguage")]
        public string SourceLanguage { get; set; }

        [JsonPropertyName("targetLanguages")]
        public List<string> TargetLanguages { get; set; }

        [JsonPropertyName("file")]
        public string File { get; set; }

        [JsonPropertyName("originalFileName")]
        public string OriginalFileName { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("origin")]
        public string Origin { get; set; }

        [JsonPropertyName("savingMode")]
        public string SavingMode { get; set; }

        [JsonPropertyName("format")]
        public string Format { get; set; }

        [JsonPropertyName("outputFormat")]
        public string OutputFormat { get; set; }

        [JsonPropertyName("masters")]
        public bool Masters { get; set; }

        [JsonPropertyName("formatting")]
        public bool Formatting { get; set; }

        [JsonPropertyName("route")]
        public string Route { get; set; }

        [JsonPropertyName("separator")]
        public string Separator { get; set; }

        [JsonPropertyName("elements")]
        public List<int> Elements { get; set; }

        [JsonPropertyName("ranges")]
        public Dictionary<string, RangeDetails> Ranges { get; set; }

        [JsonPropertyName("shortcodedict")]
        public Dictionary<string, List<string>> ShortcodeDict { get; set; }

        [JsonPropertyName("frontMatterList")]
        public List<List<string>> FrontMatterList { get; set; }
    }

    public class RangeDetails
    {
        [JsonPropertyName("rows")]
        public List<int> Rows { get; set; }

        [JsonPropertyName("columns")]
        public List<int> Columns { get; set; }

        [JsonPropertyName("ranges")]
        public List<RangeItem> Ranges { get; set; }
    }

    public class RangeItem
    {
        [JsonPropertyName("item1")]
        public string Item1 { get; set; }

        [JsonPropertyName("item2")]
        public string Item2 { get; set; }
    }
}
