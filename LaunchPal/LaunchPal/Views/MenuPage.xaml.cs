using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaunchPal.Models;
using Xamarin.Forms;

namespace LaunchPal.Views
{
    public partial class MenuPage : ContentPage
    {
        public ListView ListView => listView;

        public MenuPage()
        {
            InitializeComponent();

            var masterPageItems = new List<MasterPageItem>
            {
                new MasterPageItem
                {
                    Title = "Overview",
                    IconSource = "overview.png",
                    TargetType = typeof(OverviewPage),
                },
                new MasterPageItem
                {
                    Title = "Launch",
                    IconSource = "overview.png",
                    TargetType = typeof(LaunchPage)
                },
                new MasterPageItem
                {
                    Title = "News",
                    IconSource = "overview.png",
                    TargetType = typeof(OverviewPage)
                },
                new MasterPageItem
                {
                    Title = "Astronauts",
                    IconSource = "overview.png",
                    TargetType = typeof(OverviewPage)
                },
                new MasterPageItem
                {
                    Title = "Search",
                    IconSource = "overview.png",
                    TargetType = typeof(OverviewPage)
                },
                new MasterPageItem
                {
                    Title = "Settings",
                    IconSource = "overview.png",
                    TargetType = typeof(OverviewPage)
                }
            };

            listView.ItemsSource = masterPageItems;
        }

        private void Cell_OnTapped(object sender, EventArgs e)
        {
            
        }
    }
}
