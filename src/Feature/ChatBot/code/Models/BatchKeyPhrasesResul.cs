using System.Collections.Generic;

namespace Sitecore.Demo.Group.Feature.ChatBot
{
    public class BatchKeyPhrasesResul
    {
        public List<DocumentKeyPhrasesResult> Documents { get; set; }
        public List<object> Errors { get; set; }
    }
}