using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchPal.ViewModels
{
    class ViewModelBase
    {
        public bool IsLoading { get; set; }
        public bool HasError { get; set; }
        public Exception Exception { get; set; }

        protected async Task WaitAndExecute(Action actionToExecute)
        {
            await Task.Delay(100);

            actionToExecute();
        }
    }
}
