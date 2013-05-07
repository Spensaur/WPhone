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
using System.Xml;
using System.IO;

namespace CineQuest.XMLclasses
{
    public class FestivalParser
    {
        /* Instance fields */
        String data;
        Festival festival;

        public FestivalParser()
        {
            festival = new Festival();
        }

        public Festival Parse(String aData)
        {
            data = aData;

            /* Create XmlReader convert string to Xml */
            XmlReader reader = XmlReader.Create(new StringReader(data));

            while (reader.Read())
            {
                
                if (reader.Name.Equals("films"))
                {
                    /* into <films> */
                    MessageBox.Show(reader.HasAttributes.ToString());
                    if (reader.HasAttributes)
                    {

                    }
                    //MessageBox.Show(reader.Name.ToString());
                }
                
            }

            return festival;
        }
    }
}
