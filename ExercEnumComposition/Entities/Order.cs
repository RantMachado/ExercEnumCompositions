using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using ExercEnumComposition.Entities.Enums;

namespace ExercEnumComposition.Entities
{
    class Order
    {
        //properties 
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        
        //constructs 
        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        //Métodos da classe
        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0;

            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();
            }

            return sum;
        }
        //Imprimindo na tela
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\nORDER SUMMARY:");
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());

            sb.Append("Client: ");
            sb.Append(Client.Name);
            sb.Append(" (" + Client.BirthDate.ToString("dd/MM/yyyy") + ") - ");
            sb.AppendLine(Client.Email);
            sb.AppendLine("Order items: ");

            foreach (OrderItem item in Items)
            {
                sb.Append(item.Product.Name);
                sb.Append(", $" + item.Price.ToString("f2", CultureInfo.InvariantCulture));
                sb.Append(", Quantity: " + item.Quantity);
                sb.AppendLine(", subtotal: " + item.SubTotal().ToString("f2", CultureInfo.InvariantCulture));
            }

            sb.Append("Total price: ");
            sb.Append("$");
            sb.Append(Total().ToString("f2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
