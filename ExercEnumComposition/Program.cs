using System;
using System.Globalization;
using ExercEnumComposition.Entities;
using ExercEnumComposition.Entities.Enums;

/*
 * Author: Randolfo Machado
 * data de realização: 19/06/2019
 * Exercicio de fixação sobre Enums e Composição
 */

namespace ExercEnumComposition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string nome = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime dataNascimento = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            int qteItens = int.Parse(Console.ReadLine());

            Client c1 = new Client(nome, email, dataNascimento);
            
            Order order = new Order(DateTime.Now, status, c1);

            for (int i = 0; i < qteItens; i++)
            {
                Console.WriteLine($"Enter #{i+1} item data:");
                Console.Write("Product name: ");
                string nomeProduto = Console.ReadLine();
                Console.Write("Product price: ");
                double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int qteProduto = int.Parse(Console.ReadLine());

                Product produto = new Product(nomeProduto, precoProduto);                

                OrderItem orderItem = new OrderItem(qteProduto, produto.Price,produto);

                order.AddItem(orderItem);  
            }

            Console.WriteLine(order);

        }
    }
}
