using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Kagisho_Phahlamohlaka_PRG252_OrderSystem
{
    class Order_class
    {
        private int order_id;
        private string name;
        private string surname;
        private int phone_number;
        private string email;
        private string type_of_cake;
        private int quantity;
        private double price;
        private DateTime collection_date;
        private string special_message;


        public Order_class(int order_id,string name, string surname, int phone_number, string email, string type_of_cake, int quantity, double price, DateTime collection_date, string special_message)
        {
            this.order_id = order_id;
            this.Name = name;
            this.Surname = surname;
            this.Phone_number = phone_number;
            this.Email = email;
            this.Type_of_cake = type_of_cake;
            this.Quantity = quantity;
            this.Price = price;
            this.Collection_date = collection_date;
            this.Special_message = special_message;
        }
        public int Order_id { get => order_id; set => order_id = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Phone_number { get => phone_number; set => phone_number = value; }
        public string Email { get => email; set => email = value; }
        public string Type_of_cake { get => type_of_cake; set => type_of_cake = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public double Price { get => price; set => price = value; }
        public DateTime Collection_date { get => collection_date; set => collection_date = value; }
        public string Special_message { get => special_message; set => special_message = value; }

        public Order_class() { }
        public Order_class(int order_id)
        {
            this.order_id = order_id;
        }

        public void Delete()
        {
            Datahandler_Orders_ data = new Datahandler_Orders_();
            data.Delete(order_id);
        }

        public void Insert()
        {
            Datahandler_Orders_ data = new Datahandler_Orders_();
            data.Insert(Surname, Phone_number, Email, Type_of_cake, Quantity, Price, Collection_date, Special_message, Name);
        }



    }

    
}
