using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ClassLibrary_Serializer
{
    internal class OrderedItem
    {
        [XmlAttribute]
        public string ProductName;
        public int Quantity;
        public decimal USPrice;
        public string Comment;
        public DateTime ShipDate;
    }
}
