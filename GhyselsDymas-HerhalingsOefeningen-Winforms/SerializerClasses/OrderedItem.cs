using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ClassLibrary_Serializer
{
    public class OrderedItem
    {
        [XmlAttribute]
        public string ProductName;
        public int Quantity;
        public decimal USPrice;
        public string Comment;
        public DateTime ShipDate;

        public override string ToString()
        {

            string purchaseOrderString = $"Ordered Item: '{ProductName}, {Quantity}, {USPrice}, {Comment}, {ShipDate}'";

            return purchaseOrderString;
        }
    }
}
