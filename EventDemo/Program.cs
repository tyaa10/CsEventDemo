using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();
            Subscriber subscriber = new Subscriber();
            Consumer consumer = new Consumer();
            Consumer consumer2 = new Consumer();

            subscriber.MakeASubscription(publisher, consumer);
            subscriber.MakeASubscription(publisher, consumer2);
            
            publisher.Publish(new MagazineEventArgs() {
                Title = "T1",
                Content = "Lorem ipsum dolor",
                PubDate = new DateTime()
            });
            Thread.Sleep(3000);
            // publisher.consumers = null;
            publisher.Publish(new MagazineEventArgs()
            {
                Title = "T2",
                Content = "Lorem ipsum dolor 2",
                PubDate = new DateTime()
            });
        }
    }
}
