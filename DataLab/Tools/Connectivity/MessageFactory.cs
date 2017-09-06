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

        public const string whiteline = "\r\n";

        public static EmailMessage AsMessage(User user, PlanningItem item)
        {
            if (item is Activity)
                return AsMessage(user, item as Activity);
            else if (item is Reflection)
                return AsMessage(user, item as Reflection);
            else if (item is ToDoItem)
                return AsMessage(user, item as ToDoItem);
            else if (item is ToDoItemSet)
                return AsMessage(user, item as ToDoItemSet);

            return new EmailMessage();
        }

        private static EmailMessage AsMessage(User user, Activity act)
        {
            EmailMessage email =    new EmailMessage();
            email.Subject = String.Format("{0} sends you it's activity: {1}", user.UserName, act.Name);
            email.Body    = String.Format("'{0}: {1}' at {2} {whiteline}{whiteline} Your sincerely, {whiteline} {3}", act.Name, act.Description, act.Start.ToString("R"), user.UserName);


            return email;  
        }

        private static EmailMessage AsMessage(User user, Reflection reflect)
        {
            EmailMessage email = new EmailMessage();
            email.Subject = String.Format("{0} sends you it's reflection: {1}", user.UserName, reflect.Name);
            email.Body = String.Format("'{0}: {1}' at {2} {whiteline}{whiteline} Your sincerely, {whiteline} {3}", reflect.Name, reflect.Description, reflect.Time.ToString("R"), user.UserName);

            EmailAttachment attachment = new EmailAttachment();

            attachment.Data = reflect.PhotoFile;
            
            email.Attachments.Add(attachment);

            return email;
        }

        private static EmailMessage AsMessage(User user, ToDoItem tdi)
        {
            EmailMessage email = new EmailMessage();
            email.Subject = String.Format("{0} sends you it's ToDoIten: {1}", user.UserName, tdi.Name);
            string line =   String.Format("- '{0}'- {1} \t isDone: {2} {whiteline}", tdi.Name, tdi.Description, tdi.IsDone);
            line        +=  String.Format("Your sinceley, {whiteline} ", user.UserName);

            email.Body = line;

            return email;
        }

        private static EmailMessage AsMessage(User user, ToDoItemSet tdi)
        {
            EmailMessage email = new EmailMessage();
            email.Subject = String.Format("{0} sends you it's ToDo List: {1}", user.UserName, tdi.Name);

            StringBuilder builder = new StringBuilder(100 * tdi.Children.Count);
            builder.Append(String.Format("ToDo List '{0}' - {1} {whiteline}{whiteline} ", tdi.Name, tdi.Description) );
                
            foreach (ToDoItem item in tdi.Children)
            {
                string line = String.Format("- '{0}'- {1} \t isDone: {2} {whiteline}", item.Name, item.Description, item.IsDone);
                builder.Append(line);
            }

            builder.Append(String.Format("Your sinceley, {whiteline} ", user.UserName));


            email.Body = builder.ToString();


            return email;
        }
    }
}
