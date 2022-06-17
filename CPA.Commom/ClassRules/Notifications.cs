using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPA.Commom.ClassRules {
    public class Notifications {

        private List<Notification> notifications = new List<Notification>();

        public ICollection<Notification> GetAll() => notifications;

        public void Add(string message) {

            notifications.Add(new Notification(message));

        }

        public void CauseThrowIfHaveNotifications() {

            if(notifications.Count > 0) 
                throw new Exception(GetAllMessages());

        }

        public string GetAllMessages() {

            string result = "";

            notifications.ForEach((notification) => {
                result = result + $"{notification.message}{Environment.NewLine}";
            });

            return result;
        }

    }
}
