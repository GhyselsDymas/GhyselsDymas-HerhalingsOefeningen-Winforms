using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhyselsDymas_HerhalingsOefeningen_Winforms.Repository
{
    internal class Items
    {
        private string productname;
        private int? qauntity;

        public Items(string productname, int? qauntity)
        {
            this.productname = productname;
            this.qauntity = qauntity;
        }

        public string ProcuctName { get; set; }
        public int Quantity { get; set; }
    }
}
