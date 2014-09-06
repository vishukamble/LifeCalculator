using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            performCalculation();
        }

        private void performCalculation()
        {
            var selectedRadio = myGrid.Children.OfType<RadioButton>().FirstOrDefault(r => r.IsChecked == true);
            var option = selectedRadio.Tag.ToString();

            alive.Text = option;

            DateTime date1 = new DateTime(dateOfBirth.Date.Year, dateOfBirth.Date.Month, dateOfBirth.Date.Day);
            DateTime date2 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            
            TimeSpan interval = date2 - date1;
            
            switch(option)
            {
                case "Months":
                    alive.Text = (date2.Subtract(date1).Days / (365 / 12)).ToString() + " " + option + " lived";                  
                    break;
                case "Days":
                    alive.Text = interval.TotalDays.ToString() + " " + option + " lived";
                    break;
                case "Seconds":
                    alive.Text = interval.TotalSeconds.ToString() + " " + option + " lived";
                    break;
                case "Hours":
                    alive.Text = interval.TotalHours.ToString() + " " + option + " lived";
                    break;
                case "Minutes":
                    alive.Text = interval.TotalMinutes.ToString() + " " + option + " lived";
                    break;
                case "Years":
                    alive.Text = (date2.Subtract(date1).Days / (365)).ToString() + " " + option + " lived";
                    break;
            }
        }
    }
}
