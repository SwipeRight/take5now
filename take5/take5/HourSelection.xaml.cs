using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using take5.Classes;

// The Items Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234233

namespace take5
{
    /// <summary>
    /// A page that displays a collection of item previews.  In the Split Application this page
    /// is used to display and select one of the available groups.
    /// </summary>

    public class Payload
    {
        public int hour { get; set; }
        public int minute { get; set; }
        public string activity { get; set; }
    }

    public sealed partial class HourSelection : take5.Common.LayoutAwarePage
    {
        private DatabaseConnection myDB;
        private Middleware middleware;

        public HourSelection()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);
        }
		
		Payload payload = new Payload();

        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="navigationParameter">The parameter value passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested.
        /// </param>
        /// <param name="pageState">A dictionary of state preserved by this page during an earlier
        /// session.  This will be null the first time a page is visited.</param>


        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            var parameter = e.Parameter as string;
            this.DataContext = this;
            myDB = new DatabaseConnection();
            myDB.initialiseDatabase();
            middleware = new Middleware();
            middleware.login();
        }
		
		private void select9am(object sender, RoutedEventArgs e)
		{
			payload.hour = 9;
			this.Frame.Navigate(typeof(MinuteSelection), payload);
		}
		
		private void select10am(object sender, RoutedEventArgs e)
		{
            payload.hour = 10;
			this.Frame.Navigate(typeof(MinuteSelection), payload);
		}
		
		private void select11am(object sender, RoutedEventArgs e)
		{
            payload.hour = 11;
			this.Frame.Navigate(typeof(MinuteSelection), payload);
		}
		
		private void select12pm(object sender, RoutedEventArgs e)
		{
            payload.hour = 12;
			this.Frame.Navigate(typeof(MinuteSelection), payload);
		}
		
		private void select1pm(object sender, RoutedEventArgs e)
		{
            payload.hour = 1;
			this.Frame.Navigate(typeof(MinuteSelection), payload);
		}
		
		private void select2pm(object sender, RoutedEventArgs e)
		{
            payload.hour = 2;
			this.Frame.Navigate(typeof(MinuteSelection), payload);
		}
		
		private void select3pm(object sender, RoutedEventArgs e)
		{
            payload.hour = 3;
			this.Frame.Navigate(typeof(MinuteSelection), payload);
		}
		
		private void select4pm(object sender, RoutedEventArgs e)
		{
            payload.hour = 4;
			this.Frame.Navigate(typeof(MinuteSelection), payload);
		}
		
		private void select5pm(object sender, RoutedEventArgs e)
		{
            payload.hour = 5;
			this.Frame.Navigate(typeof(MinuteSelection), payload);
		}
		
		private void selectRightNow(object sender, RoutedEventArgs e)
		{
			DateTime rightNow = DateTime.Now;
			int hour = rightNow.Hour;
			int minute = rightNow.Minute;
            if(minute > 0 & minute < 16)
            {
                minute = 15;
            }
            if (minute > 15 & minute < 31)
            {
                minute = 30;
            }
            if (minute > 30 & minute < 46)
            {
                minute = 45;
            }
            if (minute > 45 & minute < 1)
            {
                minute = 00;
            }
			payload.hour = hour;
			payload.minute = minute;
			this.Frame.Navigate(typeof(ActivitySelection), payload);
		}

        protected override void LoadState(Object navigationParameter, Dictionary<String, Object> pageState)
        {
            // TODO: Assign a bindable collection of items to this.DefaultViewModel["Items"]
        }
    }
}
