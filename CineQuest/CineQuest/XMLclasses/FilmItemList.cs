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
using System.Collections;
using System.Collections.Generic;

namespace CineQuest
{
    //This class creates a list of filmitems to populate the film page.
    public class FilmItemList
    {
        public List<FilmItem> Itemlist;
        Festival festival;
        public FilmItemList(Festival f)
        {
            festival = f;
        }

        /**
         * Populates with test data
         * */
        public FilmItemList()
        {
            Itemlist = new List<FilmItem>();
            for (int i = 0; i < 10; i++)
            {
                Itemlist.Add(new FilmItem(i + "one", i + "two", i + "three", i + "four"));
            }
        }

         public void populateList()
         {
             Itemlist = new List<FilmItem>();
             foreach (Film f in festival.films.filmsList)
             {
                 foreach (Schedule s in festival.schedules.schedulesList)
                 {
                     if (f.id.Equals(s.id))
                     {
                         FilmItem temp = new FilmItem();
                         temp.lineone = f.title;
                         temp.linetwo = s.startTime + " - " + s.endTime;
                         temp.linefour = f.description;
                         Itemlist.Add(temp);
                     }
                 }
             }
         }
    }
}
