using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    class Consumer
    {
        public void Fetch(object sender, MagazineEventArgs magazine) {
            Console.WriteLine("I'm reading...");
            Console.WriteLine("Title: " + magazine.Title);
        }
    }
}
