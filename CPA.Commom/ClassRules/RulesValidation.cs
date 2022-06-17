using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPA.Commom.ClassRules {
    public class RulesValidation {

        public Notifications notifications { get; private set; }

        public RulesValidation() {
            notifications = new Notifications();
        }

        // --- Numbers -----------------------------------------

        public void Equal(double value, double expected, string message) {

            if(value == expected)
                notifications.Add(message);

        }

        public void Greater(double value, double expected, string message) {

            if (value > expected)
                notifications.Add(message);

        }

        public void GreaterOrEqual(double value, double expected, string message) {

            if(value >= expected)
                notifications.Add(message);

        }

        public void Less(double value, double expected, string message) {

            if(value < expected)
                notifications.Add(message);

        }

        public void LessOrEqual(double value, double expected, string message) {

            if(value <= expected)
                notifications.Add(message);

        }

        // --- Strings -----------------------------------------

        public void Equal(string value, string expected, string message) {

            if(value.Equals(expected))
                notifications.Add(message);

        }

        public void isLengthLessThan(string value, int length, string message) {

            Less(value.Length, length, message);

        }

        public void isGreaterLessThan(string value, int length, string message) {

            Greater(value.Length, length, message);

        }

        public void isNull(string value, string message) {

            if(value == null)
                notifications.Add(message);

        }

        public void isEmpty(string value, string message) {

            if(value.Equals(""))
                notifications.Add(message);

        }

        public void isNullOrEmpty(string value, string message) {

            if(value == null || value.Equals(""))
                notifications.Add(message);

        }

        // --- Bool -----------------------------------------

        public void isTrue(bool value, string message) {

            if(value)
                notifications.Add(message);

        }

        public void isFalse(bool value, string message) {

            if (value)
                notifications.Add(message);

        }


    }
}
