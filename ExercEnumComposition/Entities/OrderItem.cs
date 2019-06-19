namespace ExercEnumComposition.Entities
{
    class OrderItem
    {
        //Atributos/Auto-Properties
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }
        //Construtores
        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }
        //Métodos da Classe
        public double SubTotal()
        {
            return Quantity * Price;
        }
    }
}
