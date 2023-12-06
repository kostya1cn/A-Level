namespace Lesson6HW
{
    public class Product
    {
        public class ProductInfo
        {
            public string? Name { get; set; }
            public int Price { get; set; }
            public int Quantity { get; set; }
        }

        public Dictionary<string, ProductInfo> product = new Dictionary<string, ProductInfo>();
        public Dictionary<string, int> cart = new Dictionary<string, int>();

        public ProductInfo product1 = new ProductInfo { Name = "Пиво", Price = 100, Quantity = 10 };
        public ProductInfo product2 = new ProductInfo { Name = "Ктулху", Price = 1, Quantity = 1 };
        public ProductInfo product3 = new ProductInfo { Name = "Телевизор", Price = 200, Quantity = 5 };

        public Product()
        {
            product.Add(product1.Name, product1);
            product.Add(product2.Name, product2);
            product.Add(product3.Name, product3);
        }
    }
}
