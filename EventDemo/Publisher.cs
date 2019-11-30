using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    class Publisher
    {
        public event EventHandler<MagazineEventArgs> consumers;
        public void Publish(MagazineEventArgs magazine) {
            /* if (consumers != null)
            {
                consumers(this, magazine);
            } */
            consumers?.Invoke(this, magazine);
        }
    }
}
