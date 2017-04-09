using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaunchPal.Models;
using Xamarin.Forms;

namespace LaunchPal.Views
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();

            MenuPage.ListView.ItemSelected += OnItemSelected;
        }

        private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;
            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                MenuPage.ListView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}
