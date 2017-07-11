using System.Collections.Generic;

namespace Sitecore.Demo.Group.Feature.ChatBot
{
    public class BatchSentimentResult
    {
        public List<DocumentSentimentResult> Documents { get; set; }
        public List<object> Errors { get; set; }
    }
}