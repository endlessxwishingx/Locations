using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace Locations.Pages
{
    public class TripOverview : ContentPage
    {
        public TripOverview()
        {
            Content = new TableView
            {
                Intent = TableIntent.Menu,
                Root = new TableRoot
                {
                    new TableSection("General Information")
                    {
                        new EntryCell
                        {
                            Label = "Trip ID",
                            Placeholder = "Optional"
                        }
                    },

                    new TableSection("Leg Information")
                    {
                        new TextCell
                        {
                            Text = "No Flight Details",
                            Detail = "Tap to Edit"
                        },
                        new TextCell
                        {
                            Text = "Add Another Flight Leg"
                        }
                    },

                    new TableSection("Analyzed Systems")
                    {
                        new SwitchCell
                        {
                            Text = "Boeing Broadband"
                        },
                        new SwitchCell
                        {
                            Text = "Swift 64"
                        },
                        new SwitchCell
                        {
                            Text = "Swift Broadband"
                        },
                        new SwitchCell
                        {
                            Text = "Viasat"
                        }
                    }
                }
            };
        }
    }
}
