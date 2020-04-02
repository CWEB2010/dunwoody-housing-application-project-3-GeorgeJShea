/*
George Shea Sseta
made 4/1/2020
Version 1.0
Version date 4/1/2020
use controlls back end of app

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;

namespace WhereYouBelong
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {

        public MainWindow()
        {

            InitializeComponent();
            backDrop(0);
        }
        public void userNameButton(Object sender, RoutedEventArgs e)
        {

        }
        public void passWordButton(Object sender, RoutedEventArgs e)
        {
            string pass = passwordEntry.Text;
            string user = userEntry.Text;

            if (pass == "test" && user == "test")
            {
                backDrop(1);
            }
        }

        public void tabOneButton(Object sender, RoutedEventArgs e)
        {
            tabOrg(1);
            Trace.WriteLine("the button worked.");
        }

        public void tabTwoButton(Object sender, RoutedEventArgs e)
        {
            tabOrg(2);
            Trace.WriteLine("the button worked begone.");
        }



        public void backDrop(int correct) 
        {
            var backDropArray = new (Rectangle rectangles, Button buttons)[]
            {
                (blackBox, buttonOne),
                (blackBox, buttonTwo)
            };
            int count = 0;
            if (correct == 0)
            {
                foreach (var inter in backDropArray)
                {
                    backDropArray[count].rectangles.Visibility = System.Windows.Visibility.Hidden;
                    backDropArray[count].buttons.Visibility = System.Windows.Visibility.Hidden;
                    count = count + 1;
                }
            }
            else if (correct == 1)
            {
                count = 0;
                foreach (var inter in backDropArray)
                {
                    backDropArray[count].rectangles.Visibility = System.Windows.Visibility.Visible;
                    backDropArray[count].buttons.Visibility = System.Windows.Visibility.Visible;
                    entryButton.Visibility = System.Windows.Visibility.Hidden;
                    passwordEntry.Visibility = System.Windows.Visibility.Hidden;
                    userEntry.Visibility = System.Windows.Visibility.Hidden;
                    count = count + 1;
                }
            }
        }
        public void tabOrg(int choice)
        {
            var tabOneArray = new (Rectangle rectangles, Button buttons)[]
            {
                (blueBox, entryButton),
            };

            var tabTwoArray = new (Rectangle rectangles, Button buttons)[]
            {
                (blackBox, entryButton),
            };

            // list of rectangles on screen 
            if (choice == 1)
            {
                int counter = 0;
                foreach (var interator in tabOneArray)
                {
                    tabOneArray[counter].rectangles.Visibility = System.Windows.Visibility.Visible;
                    tabOneArray[counter].buttons.Visibility = System.Windows.Visibility.Visible;
                    counter = +counter;
                }

                counter = 0;
                foreach (var interator in tabTwoArray)
                {
                    tabTwoArray[0].rectangles.Visibility = System.Windows.Visibility.Hidden;
                    tabTwoArray[0].buttons.Visibility = System.Windows.Visibility.Hidden;
                    counter = +counter;
                }
            }
            else if (choice == 2)
            {
                foreach (var interator in tabOneArray)
                {
                    tabOneArray[0].rectangles.Visibility = System.Windows.Visibility.Hidden;
                    tabOneArray[0].buttons.Visibility = System.Windows.Visibility.Hidden;
                }

                foreach (var interator in tabTwoArray)
                {
                    tabTwoArray[0].rectangles.Visibility = System.Windows.Visibility.Visible;
                    tabTwoArray[0].buttons.Visibility = System.Windows.Visibility.Visible;
                }

            }
            else if (choice == 3)
            {
                foreach (var interator in tabOneArray)
                {
                    tabOneArray[0].rectangles.Visibility = System.Windows.Visibility.Hidden;
                    tabOneArray[0].buttons.Visibility = System.Windows.Visibility.Hidden;
                }

                foreach (var interator in tabTwoArray)
                {
                    tabTwoArray[0].rectangles.Visibility = System.Windows.Visibility.Hidden;
                    tabTwoArray[0].buttons.Visibility = System.Windows.Visibility.Hidden;
                }
            }
        }
    }
}
