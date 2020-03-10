using System.Collections.Generic;

namespace ModelShared.Models
{
    public class TextUtility
    {
        public string DetectedLanguage { get; set; }
        public string TranslateLanguage { get; set; }
        public IEnumerable<string> Entities { get; set; }
        public string KeyWord { get; set; }
        public float SentimentalRate { get; set; }
        public IEnumerable<string> Intents { get; set; }
    }
}
