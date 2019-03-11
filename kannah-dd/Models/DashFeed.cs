using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kannah_dd.Models
{
    internal class DashFeed
    {
        [JsonProperty("_uniqueIdentifier")]
        internal int id { get; set; }
        [JsonProperty("name")]
        internal string Name { get; set; }
        [JsonProperty("platform")]
        internal string Platform { get; set; }
        [JsonProperty("aliases")]
        internal string[] Alias { get; set; }
        [JsonProperty("isCustom")]
        internal bool isCustom { get; set; }
        [JsonProperty("installed")]
        internal bool isInstalled { get; set; }
        [JsonProperty("_isMajorVersioned")]
        internal bool isMajorVersioned { get; set; }
        [JsonProperty("feed")]
        internal string Feed { get; set; }
        [JsonProperty("feed")]
        internal string FeedUrl { get; set; }
        [JsonProperty("doesNotHaveVersions")]
        internal bool doesNotHaveVersions { get; set; }
        [JsonProperty("icon")]
        internal string Icon { get; set; }
        [JsonProperty("size")]
        internal string Size { get; set; }
        [JsonProperty("authorLinkHref")]
        internal string AuthorLinkHref { get; set; }
        [JsonProperty("authorLinkText")]
        internal string AuthorLinkText { get; set; }
        internal string detailString { get; set; }
    }
}
