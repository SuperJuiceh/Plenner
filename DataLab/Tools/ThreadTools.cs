using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Core;

namespace DataLab.Tools
{
    public static class ThreadTools
    {

        public delegate void voidDelegate();

        public static async void runInCoreDispatcher(voidDelegate del) {
            await CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.High, () => del());
        }

    }
}
