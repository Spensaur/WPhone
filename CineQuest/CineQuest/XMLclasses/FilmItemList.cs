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
using System.Runtime.Serialization;

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
            Itemlist.Add(new FilmItem("7 Lives Of Chance",
                "12:00 - 2:30", "linethree", "Confront your fears, one balloon at a time. In this psychedelic comedy, a lone red balloon, dearly cherished from childhood, multiplies as it leads Chance on a journey of acknowledgement. <br><br>Chance buries herself in a dreamlike world, glossing over the unpleasantness she observes and hoarding everything from never-been-worn dresses to packaged food. With a string of surreal deaths occurring close to her, the ghosts of the recently deceased begin to inhabit her house, bringing this claustrophobe's worst nightmare to life. Her home and mind begin to erupt with the cluttered memories she must confront, slowly stretching her mind into insanity. As her high school reunion approaches, Chance must come face to face with the one fear that she has yet to accept. – Kristy Yip"));

        }

        public void populateList()
        {
            Itemlist = new List<FilmItem>();
            /* Once entire Festival gets loaded this will work */
            /*
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
            }*/

            /* loads JUST films in the Festival object */
            foreach (Film f in festival.films.filmsList)
            {
                FilmItem temp = new FilmItem();
                temp.lineone = f.title;
                temp.linetwo = "start - end"; // s.startTime + " - " + s.endTime;
                temp.linefour = f.description;
                Itemlist.Add(temp);
            }
        }
    }
}
