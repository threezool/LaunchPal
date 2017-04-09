using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaunchPal.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LaunchPal.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LaunchPage : CarouselPage
    {
        public LaunchPage()
        {
            InitializeComponent();
            BindingContext = new Launch();
            this.CurrentPage = Children[];
        }
    }
}
