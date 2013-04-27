using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace CineQuest
{
    public class Film
    {
        [System.Xml.Serialization.XmlElementAttribute("id")]
        public string id { get; set; }

        [System.Xml.Serialization.XmlElement("title")]
        public string title { get; set; }

        [System.Xml.Serialization.XmlElement("description")]
        public string description { get; set; }

        [System.Xml.Serialization.XmlElement("genre")]
        public string genre { get; set; }

        [System.Xml.Serialization.XmlElement("imageURL")]
        public string imageURL { get; set; }

        [System.Xml.Serialization.XmlElement("director")]
        public string director { get; set; }

        [System.Xml.Serialization.XmlElement("producer")]
        public string producer { get; set; }

        [System.Xml.Serialization.XmlElement("cinematographer")]
        public string cinematographer { get; set; }

        [System.Xml.Serialization.XmlElement("editor")]
        public string editor { get; set; }

        [System.Xml.Serialization.XmlElement("cast")]
        public string cast { get; set; }

        [System.Xml.Serialization.XmlElement("country")]
        public string country { get; set; }

        [System.Xml.Serialization.XmlElement("language")]
        public string language { get; set; }
    }
}
