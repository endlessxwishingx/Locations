using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace Locations.Pages
{
    public class HomeScreenTabs : TabbedPage
    {
        public HomeScreenTabs()
        {
            var startPage = new NavigationPage(new TripOverview() { Title = "Trip Overview" });
            startPage.Title = "Trip Overview";
            var mapPage = new MapOverview() ;
            mapPage.Title = "Map Overview";
            var settingsPage = new NavigationPage(new Settings() { Title = "Settings" });
            settingsPage.Title = "Settings";

            Children.Add(startPage);
            Children.Add(mapPage);
            Children.Add(settingsPage);

        }
    }
}
