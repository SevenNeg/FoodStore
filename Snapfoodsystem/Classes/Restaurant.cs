using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Snapfoodsystem
{
    public partial class Restaurant
    {
        public string Name { get; set; }
        public string description { get; set; }
        public StoreType Type { get; set; }
        public Address Location { get; set; }
        public string Opensat { get; set; }

        public bool takeaway { get; set; }
    }
    public partial class Restaurant
    {
        public string CartPrice { get; set; }

        public string sort_options { get; set; }

        public string Exceptions { get; set; }

        public string URL { get; set; }
    }
    public class Address
    {
        public string Lat { get; set; }
        public string Long { get; set; }
        public string FullAddress { get; set; }
    }
}
