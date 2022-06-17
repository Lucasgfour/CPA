using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPA.Commom.ClassRules {
    public class Notification {

        public string message { get; private set; }

        public Notification(string message) {
            this.message = message;
        }


    }
}
