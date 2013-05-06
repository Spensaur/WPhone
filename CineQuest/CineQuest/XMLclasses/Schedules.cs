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
using System.Xml.Serialization;

namespace CineQuest
{
    [XmlRoot(ElementName = "schedules")]
    public class Schedules
    {
        [XmlArray("schedules")]
        [XmlArrayItem("schedule", typeof(Schedule))]
        public Schedule[] schedules { get; set; }
    }
}
