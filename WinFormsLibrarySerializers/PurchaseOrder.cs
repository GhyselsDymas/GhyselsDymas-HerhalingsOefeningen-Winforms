using ClassLibrary_Serializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GhyselsDymas_HerhalingsOefeningen_Winforms.Serializer
{
    internal class PurchaseOrder
    {

        [XmlAttribute]
        public int PurchaseOrderNumber;
        public DateTime OrderDate;

        [XmlElement]
        public Address Address;
        public string DeliveryNotes;
        [XmlArrayAttribute("Items")]
        public OrderedItem[] OrderedItems;

    }
}
