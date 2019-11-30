using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    class Subscriber
    {
        public void MakeASubscription(Publisher publisher, Consumer consumer) {
            publisher.consumers += consumer.Fetch; // = new EventHandler<MagazineEventArgs>(consumer.Fetch);
            // .Add(consumer.Fetch);
        }
    }
}
