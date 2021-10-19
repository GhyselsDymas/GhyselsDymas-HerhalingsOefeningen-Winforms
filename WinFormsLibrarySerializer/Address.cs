using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ClassLibrary_Serializer
{
    internal class Address
    {
        [XmlElementAttribute(IsNullable = false)]
        public string Name;
        public string Street;
        public string City;
        public string CA;
        public int Zip;
        public string Country;
    }
}
