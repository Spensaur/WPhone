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
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace CineQuest
{
    //used by FilmItemList to populate the film page
    public class FilmItem
    {
        Films films = new Films();

        public String lineone { get; set; }
        public String linetwo { get; set; }
        public String linethree { get; set; }
        public String linefour { get; set; }
        public List<String> times { get; set; }
        public List<String> locations { get; set; }

        public FilmItem()
        {
            
        }

        public FilmItem(String aone, String atwo, String athree, String afour)
        {
            lineone = aone;
            linetwo = atwo;
            linethree = athree;
            linefour = afour;
        }
    }
}
