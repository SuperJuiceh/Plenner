using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Data.Tools.GUI
{
    public class PopupMachine
    {
        /// <summary>
        /// Holds Title(string), Message(string)
        /// </summary>
        public Queue<(string, string)> PopupMessages {get; set; }
        public PopupMachine()
        {

        }

        public void addMessage(string title, string message)
        {
            PopupMessages.Enqueue((title, message));
        }
    }
    /// <summary>
    /// Placeholder for Application specific messages
    /// </summary>
    public static class StaticPopupMachine
    {

    }
}
