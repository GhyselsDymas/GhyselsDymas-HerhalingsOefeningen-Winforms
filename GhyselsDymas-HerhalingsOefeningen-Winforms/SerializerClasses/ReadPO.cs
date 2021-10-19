using GhyselsDymas_HerhalingsOefeningen_Winforms.Serializer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ClassLibrary_Serializer
{
    public class ReadPO
    {
        public PurchaseOrder ReaderPO(string filename)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(PurchaseOrder));
            //serializer.UnknownNode+= new XmlNodeEventHandler(serializer_UnknownNode);
            FileStream fs = new FileStream(filename, FileMode.Open);
            PurchaseOrder po;
            po = (PurchaseOrder) serializer.Deserialize(fs);
            return po;
        }
    }
}
