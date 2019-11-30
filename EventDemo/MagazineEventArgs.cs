using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    class MagazineEventArgs : EventArgs
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PubDate { get; set; }
    }
}
