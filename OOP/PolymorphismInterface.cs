using System.Collections;
using System.Collections.Generic;

namespace Polymorphism {
    class PolymorphismInterface {
        static void Main(string[] args) {
            IList<INotificationChannel> notificationChannels = new List<INotificationChannel>();
			
            notificationChannels.Add(new MailNotificationChannel());
            notificationChannels.Add(new SmsNotificationChannel());

			foreach (var channel in notificationChannels) {
                channel.Send(new Message());
			}
        }
    }
}
