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
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CineQuest
{
    //[Serializable()]
    //This is the main head of the XML data object
    [XmlRoot("festival")]
    public class Festival
    {
        /* Later */
        //[XmlElement("program_items")]
        //public ProgramItems programItems  { get; set; }

        [XmlElement("films")]
        public Films films { get; set; }

        [XmlElement("schedules")]
        public Schedules schedules { get; set; }

        /* Later */
        //[XmlElement("venue_Locations")]
        //public VenueLocations venueLocations { get; set; }
    }

    public class Films
    {
        [XmlArray("films")]
        [XmlArrayItem("film", typeof(Film))]
        public List<Film> filmsList { get; set; }

        public Films()
        {
            filmsList = new List<Film>();
        }
    }

    public class Film
    {
        [XmlElementAttribute("id")]
        public string id { get; set; }

        [XmlElement("title")]
        public string title { get; set; }

        [XmlElement("description")]
        public string description { get; set; }

        [XmlElement("tagline")]
        public string tagline { get; set; }

        [XmlElement("genre")]
        public string genre { get; set; }

        [XmlElement("imageURL")]
        public string imageURL { get; set; }

        [XmlElement("director")]
        public string director { get; set; }

        [XmlElement("producer")]
        public string producer { get; set; }

        [XmlElement("cinematographer")]
        public string cinematographer { get; set; }

        [XmlElement("editor")]
        public string editor { get; set; }

        [XmlElement("cast")]
        public string cast { get; set; }

        [XmlElement("country")]
        public string country { get; set; }

        [XmlElement("language")]
        public string language { get; set; }

        [XmlElement("film_info")]
        public string film_info { get; set; }
    }

    public class Schedules
    {
        [XmlArray("schedules")]
        [XmlArrayItem("schedule", typeof(Schedule))]
        public List<Schedule> schedulesList { get; set; }

        public Schedules()
        {
            schedulesList = new List<Schedule>();
        }
    }

    public class Schedule
    {
        [XmlElementAttribute("id")]
        public string id { get; set; }

        [XmlElementAttribute("program_item_id")]
        public string programItemId { get; set; }

        [XmlElementAttribute("start_time")]
        public string startTime { get; set; }

        [XmlElementAttribute("end_time")]
        public string endTime { get; set; }

        [XmlElementAttribute("venue")]
        public string venue { get; set; }
    }
}
