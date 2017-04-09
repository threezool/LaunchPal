using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchPal.ViewModels
{
    class Launch : ViewModelBase
    {
        public string LaunchName => "Testing data binding";
        public string LaunchDate { get; set; }
        public string LaunchCounter { get; set; }

        public Launch()
        {
            IsLoading = true;
            Task.Run(async () =>
            {
                await WaitAndExecute(PopulateViewModel());
            });
        }

        private Action PopulateViewModel()
        {
            return () =>
            {
                
            };
        }


    }
}
