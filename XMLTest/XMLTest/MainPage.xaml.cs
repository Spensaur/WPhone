using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace XMLTest
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void textBlock_Tap(object sender, GestureEventArgs e)
        {
            Class1 test = new Class1();
            test.getData("http://horstmann.com/sjsu/spring2013/cs185c/hw02/quiz.xml", textBlock);
            //textBlock.Text = text;

        }

        public void setTextBlockText(String s)
        {
            textBlock.Text = s;
        }
    }
}