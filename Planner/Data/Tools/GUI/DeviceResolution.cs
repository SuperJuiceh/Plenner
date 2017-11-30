using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Graphics.Display;
using Windows.UI.ViewManagement;

namespace Planner.Data.Tools.GUI
{
    public static class DeviceResolution
    {
        public static Size GetDeviceResolution()
        {
            Rect    bounds          =       ApplicationView.GetForCurrentView().VisibleBounds;

            return new Size(bounds.Width, bounds.Height);
        }

    }
}
