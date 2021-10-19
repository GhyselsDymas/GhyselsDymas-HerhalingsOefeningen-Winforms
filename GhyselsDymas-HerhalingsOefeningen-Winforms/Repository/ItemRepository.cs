using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhyselsDymas_HerhalingsOefeningen_Winforms.Repository
{
    internal class ItemRepository
    {
        private readonly SqlConnection _connection;

        public ItemRepository()
        {
            _connection = new SqlConnection("Data Source=(local);Initial Catalog=OrderData;Integrated Security=True");

            _connection.Open();
        }

        //De usings binnen deze methode geven een error (code CS8370) en ik kon deze niet gefixed gekregen.
        //Daarom dat ik alle volgende methode in comment gezet, zodat u toch mijn code en denkwijze kunt zien.

        //public List<Items> GetAllItems()
        //{

        //using var command = _connection.CreateCommand();
        //command.CommandText = "SELECT [Productname], [Quantity] FROM [Items]";

        //var item = new List<Items>();
        //using var reader = command.ExecuteReader();
        //while (reader.Read())
        //{
        //var item = MapItemsFromReader(reader);
        //items.Add(item);
        //}

        //return items;
        //}

        //public Items? GetItemByProductname(string productName)
        //{
        //using var command = _connection.CreateCommand();
        //command.CommandText = "SELECT [Productname], [Quantity] FROM [Items] WHERE [Productname] = @productName";
        //command.Parameters.AddWithValue("@productName", productName);

        //using var reader = command.ExecuteReader();
        //while (reader.Read())
        //{
        //var item = MapItemsFromReader(reader);

        //return item;
        //}

        //return null;
        //}

        //private Items MapPersonFromReader(SqlDataReader reader)
        //{
        //var productname = reader.GetString(1);
        //int? qauntity = reader.IsDBNull(2) ? null : reader.GetInt32(2);

        //return new Items(productname , qauntity);
        //}

        //public void ItemsInsert(String productName , int qauntity) 
        //{
            //using var command = _connection.CreateCommand();
            //command.CommandText = "INSERT [Productname] = @productName, [Quantity] = @qauntity INTO [Items]";
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@qauntity", qauntity);
        //}
    }
}
