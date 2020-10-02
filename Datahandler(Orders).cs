using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Kagisho_Phahlamohlaka_PRG252_OrderSystem
{
    class Datahandler_Orders_
    {
        public static string stringConnection = @"Data Source = TAUMANG-REALM\\SQLEXPRESS; Initial catalog=LoginDatabase; Integrated Security = True";

        public List<Order_class> DisplayAll()
        {
            SqlConnection connection = new SqlConnection(stringConnection);
            connection.Open();
            string query = @"SELECT *
                             FROM Order_tbl";
            SqlCommand command = new SqlCommand(query, connection);

            List<Order_class> theOrders = new List<Order_class>();

            try
            {
                SqlDataReader reading = command.ExecuteReader();
                if (reading.Read()) 
                {
                    Order_class Object = new Order_class();
                    Object.Order_id = int.Parse(reading[0].ToString());
                    Object.Surname = reading[1].ToString();
                    Object.Phone_number = int.Parse(reading[2].ToString());
                    Object.Email = reading[3].ToString();
                    Object.Type_of_cake = reading[4].ToString();
                    Object.Quantity = int.Parse(reading[5].ToString());
                    Object.Price = double.Parse(reading[6].ToString());
                    Object.Collection_date = DateTime.Parse(reading[7].ToString());
                    Object.Special_message = reading[8].ToString();
                    Object.Name = reading[9].ToString();
                }
            }
            catch (Exception err)
            {

                MessageBox.Show($"Something went wrong{err.Message}");

            }
            finally
            {
                connection.Close();
            }

            return theOrders;

        }
        public void Insert(string Surname,int Phone_number, string Email,string Type_of_cake,int Quantity, double Price,DateTime Collection_date, string Special_message,string Name)

        {
            SqlConnection connection = new SqlConnection();
            connection.Open();
            string insert = @"insert into Order_tbl(Surname,PhoneNumber,Email,TypeOfCake,Quantity,Price,CollectionDate,SpecialMessage,Name)
                              values('" + Surname + "','" + Phone_number + "','" + Email + "','" + Type_of_cake + "','" + Quantity + "','" + Price + "','" + Collection_date + "','" + Special_message + "','" + Name + "')";
            SqlCommand command = new SqlCommand(insert, connection);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Order Has been Made");
            }
            catch (Exception error)
            {
                MessageBox.Show($"Oops seems like something went wrong, one moment{error.Message}");

            }
            finally
            {
                connection.Close();
            }
        }

        public void Delete(int Order_id) {
            SqlConnection connection = new SqlConnection(stringConnection);
            connection.Open();
            string delete = @"DELETE FROM Order_tbl
                              WHERE Order_ID = " + Order_id + "";

            SqlCommand command = new SqlCommand(delete, connection);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Value has been removed");
            }
            catch (Exception error)
            {

                MessageBox.Show($@"Something is not right{error.Message}");
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
