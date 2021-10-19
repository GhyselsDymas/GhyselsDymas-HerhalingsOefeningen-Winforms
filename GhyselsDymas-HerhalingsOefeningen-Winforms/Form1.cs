using ClassLibrary_Serializer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace GhyselsDymas_HerhalingsOefeningen_Winforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadFileButton_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "XML files|*.xml";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = ofd.FileName;
            }
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("You must select a file!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            //XmlSerializer serializer = new XmlSerializer(typeof(MainForm));
            ReadPO readPO = new ReadPO();
            var PurchaseOrder = readPO.ReaderPO(textBox1.Text);

            using (var form2 = new Form2(PurchaseOrder))
            {
                form2.ShowDialog();
            }
        }
    }
}
