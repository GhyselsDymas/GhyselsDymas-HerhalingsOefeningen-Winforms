using GhyselsDymas_HerhalingsOefeningen_Winforms.Serializer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GhyselsDymas_HerhalingsOefeningen_Winforms
{
    public partial class Form2 : Form
    {

        PurchaseOrder purchaseOrder;
        public Form2(PurchaseOrder purchaseOrder)
        {
            InitializeComponent();
 
            this.purchaseOrder = purchaseOrder;

            richTextBox1.Text = purchaseOrder.ToString();
        }

        
    }
}
