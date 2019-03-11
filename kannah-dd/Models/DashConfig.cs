using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kannah_dd.Models
{
    internal class DashConfig
    {
        internal DashConfig() { }
        public readonly static string baseUrl = "https://kapeli.com";
        internal readonly string resourcePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources");
        internal readonly string feedsFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Feeds.json");

        internal Uri parseUri(string path)
        {
            return new Uri(new Uri(baseUrl), path);
        }
        internal List<DashFeed> getFeeds()
        {
            return JsonConvert.DeserializeObject<List<DashFeed>>(File.ReadAllText(this.feedsFile));
        }
    }
}
