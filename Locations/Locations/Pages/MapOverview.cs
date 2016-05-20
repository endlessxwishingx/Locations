using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace Locations.Pages
{
    public class MapOverview : ContentPage
    {
        public MapOverview()
        {
            var map = new Map(
            MapSpan.FromCenterAndRadius(
                    new Position(36, -78), Distance.FromMiles(500)))
            {
                MapType = MapType.Satellite,
                //IsShowingUser = true,
                HeightRequest = 100,
                WidthRequest = 960,
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            var stack = new StackLayout { Spacing = 0 };
            stack.Children.Add(map);
            Content = stack;

        }
    }
}
