using ClassLibrary_Serializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GhyselsDymas_HerhalingsOefeningen_Winforms.Serializer
{
    public class PurchaseOrder
    {

        [XmlAttribute]
        public int PurchaseOrderNumber;
        public DateTime OrderDate;

        [XmlElement]
        public Address Address;
        public string DeliveryNotes;
        [XmlArrayAttribute("Items")]
        public OrderedItem[] OrderedItems;

        public override string ToString() {

            string purchaseOrderString = $"'{PurchaseOrderNumber}, {OrderDate}' - {Address} - {DeliveryNotes}";

            //wou een forEach maken zodat OrderedItem elk apart inlaad
            foreach (OrderedItem item in this.OrderedItems) {
                string itemString = item.ToString();
                purchaseOrderString += $"{itemString}";
            }

            return purchaseOrderString;
        }

    }
}
