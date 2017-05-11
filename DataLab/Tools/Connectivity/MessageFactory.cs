using DataLab.Data.Planning;
using DataLab.Data.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Email;

namespace DataLab.Tools.Connectivity
{
    public static class MessageFactory
    {

        public static EmailMessage AsMessage(User user, PlanningItem item)
        {
            if (item is Activity)
                return AsMessage(user, item as Activity);
            if (item is Reflection)
                return AsMessage(user, item as Reflection);

            return new EmailMessage();
        }

        private static EmailMessage AsMessage(User user, Activity act)
        {
            EmailMessage email =    new EmailMessage();
            email.Subject = String.Format("{0} sends you it's activity: {1}", user.UserName, act.Name);
            email.Body    = String.Format("'{0}: {1}' at {2} \r\n\r\nYour sincerely {3}", act.Name, act.Description, act.Start, user.UserName);


            return email;  
        }

        private static EmailMessage AsMessage(User user, Reflection reflect)
        {
            EmailMessage email = new EmailMessage();
            email.Subject = String.Format("{0} sends you it's reflection: {1}", user.UserName, reflect.Name);
            email.Body = String.Format("'{0}: {1}' at {2} \r\n\r\nYour sincerely {3}", reflect.Name, reflect.Description, reflect.Time, user.UserName);


            return email;
        }
    }
}
