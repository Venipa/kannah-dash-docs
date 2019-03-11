using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kannah_dd.Models
{
    public class DashFeed
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("path")]
        public string Path { get; set; }
        [JsonProperty("icon")]
        public string Icon { get; set; }
        [JsonProperty("aliases")]
        public string[] Aliases { get; set; }
        [JsonProperty("hasVersioning")]
        public bool hasVersioning { get; set; }
        private DFEntry feed { get; set; }
        public DFEntry getFeed()
        {
            if (feed != null)
            {
                return feed;
            }
            try
            {
                var rc = new RestClient(DashConfig.baseUrl);
                var rr = new RestRequest("feeds/{path}", Method.GET).AddParameter("path", this.Path);
                var data = JsonConvert.DeserializeObject<DFEntry>(rc.Execute(rr).Content);
                this.feed = data;
                return data;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return null;
            }
        }

    }
    public class DashFeedInternal
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
        [JsonProperty("feedUrl")]
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
        internal string detailString
        {
            get; set;
        }
    }
}
