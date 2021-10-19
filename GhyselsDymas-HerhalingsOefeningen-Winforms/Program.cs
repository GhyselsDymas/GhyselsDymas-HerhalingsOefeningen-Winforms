using ClassLibrary_Serializer;
using GhyselsDymas_HerhalingsOefeningen_Winforms.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GhyselsDymas_HerhalingsOefeningen_Winforms
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());        

            //Voor 1 of andere reden kunnen geen van mijn Libraries of map "SerializerClasses" worden verwijderd, want anders breken de lijnen code hieronder.
            ReadPO readPO = new ReadPO();
           
            //ItemRepository itemRepository = new ItemRepository();
            //var allItems = itemRepository.GetAllItems();

        }

    }
}
