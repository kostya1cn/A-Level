namespace Lesson6HW
{
    class Program
    {
        static void Main(string[] args)
        {
            Product myProducts = new Product();

            while (true)
            {
                Console.WriteLine("This is a store. Maybe.");
                ShopService.DisplayProducts(myProducts.product);
                Console.WriteLine("1. Добавить продукт в корзину");
                Console.WriteLine("2. Показать корзину");
                Console.WriteLine("3. Купить всё из корзины");
                Console.WriteLine("4. Добавить новый продукт");
                Console.WriteLine("5. Выйти");
                Console.Write("Enter a command: ");
                string command = Console.ReadLine()!.ToLower();

                switch (command)
                {
                    case "1":
                        ShopService.AddToCart(myProducts.product, myProducts.cart);
                        break;

                    case "2":
                        ShopService.ShowCart(myProducts.cart);
                        break;

                    case "3":
                        ShopService.BuyFromCart(myProducts.product, myProducts.cart);
                        break;
                    case "4":
                        ShopService.AddNewProduct(myProducts.product);
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Некорректный выбор.");
                        break;
                }
            }
        }
    }
}