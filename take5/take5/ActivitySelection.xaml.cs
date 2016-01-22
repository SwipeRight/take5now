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
using Database;
using take5.Classes;
using take5.Common;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace take5
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class ActivitySelection : take5.Common.LayoutAwarePage
    {
        private Middleware middleware;


        public ActivitySelection()
        {
            this.InitializeComponent();
        }

        Payload finalPayload = new Payload();

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            Payload passedPayload = e.Parameter as Payload;
            finalPayload.hour = passedPayload.hour;
            finalPayload.minute = passedPayload.minute;
        }

        private void selectPool(object sender, RoutedEventArgs e)
        {
            finalPayload.activity = "Pool";
            this.Frame.Navigate(typeof(ActivitySelection), finalPayload);
        }
        private void selectCoffee(object sender, RoutedEventArgs e)
        {
            finalPayload.activity = "Coffee";
            this.Frame.Navigate(typeof(ActivitySelection), finalPayload);
        }

        private void selectTable_Tennis(object sender, RoutedEventArgs e)
        {
            finalPayload.activity = "Table Tennis";
            this.Frame.Navigate(typeof(ActivitySelection), finalPayload);
        }

        private void selectWalk(object sender, RoutedEventArgs e)
        {
            finalPayload.activity = "Walk";
            this.Frame.Navigate(typeof(ActivitySelection), finalPayload);
        }

       /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="navigationParameter">The parameter value passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested.
        /// </param>
        /// <param name="pageState">A dictionary of state preserved by this page during an earlier
        /// session.  This will be null the first time a page is visited.</param>
        protected override void LoadState(Object navigationParameter, Dictionary<String, Object> pageState)
        {
            middleware = new Middleware();
            MyDatabase.InitialiseDataBase();
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="pageState">An empty dictionary to be populated with serializable state.</param>
        protected override void SaveState(Dictionary<String, Object> pageState)
        {
            
        }

        private void poolButtonClick(object sender, RoutedEventArgs e)
        {
            var buttonID = "Pool";
            addUserToQueue(buttonID);
        }

        private void coffeeButtonClick(object sender, RoutedEventArgs e)
        {
            var buttonID = "Coffee";
            addUserToQueue(buttonID);
            
        }

        private void tenisButtonClick(object sender, RoutedEventArgs e)
        {
            var buttonID = "Tenis";
            addUserToQueue(buttonID);

        }

        private void walkButtonClick(object sender, RoutedEventArgs e)
        {
            var buttonID = "Walk";
            addUserToQueue(buttonID);

        }

        private void addUserToQueue(string activityID)
        {
            Person localUser = new Person {userID = 3};
            localUser.userEmail = "testemail@dell.com";


            var matched = middleware.checkIfCanMatch(localUser, activityID);
            if (!matched)
            {
                middleware.addPersonToQueue(localUser, activityID);
            }
        }

        
    }
}
