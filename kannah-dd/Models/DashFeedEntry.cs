using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace kannah_dd.Models
{
    [XmlRoot(ElementName = "version")]
    public class DFEntryVersion
    {
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
    }

    [XmlRoot(ElementName = "other-versions")]
    public class DFEntryOtherVersions
    {
        [XmlElement(ElementName = "version")]
        public List<Version> Version { get; set; }
    }

    [XmlRoot(ElementName = "entry")]
    public class DFEntry
    {
        [XmlElement(ElementName = "version")]
        public string Version { get; set; }
        [XmlElement(ElementName = "ios_version")]
        public string Ios_version { get; set; }
        [XmlElement(ElementName = "url")]
        public List<string> Url { get; set; }
        [XmlElement(ElementName = "other-versions")]
        public DFEntryOtherVersions Otherversions { get; set; }
    }
}
