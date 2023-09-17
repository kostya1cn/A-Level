namespace Lesson6HW
{
    public class ShopService
    {
        public static void DisplayProducts(Dictionary<string, Product.ProductInfo> products)
        {
            foreach (var kvp in products)
            {
                Console.WriteLine($"Product: Name: {kvp.Value.Name}, Price: {kvp.Value.Price}, Quantity: {kvp.Value.Quantity}");
            }
        }

        public static void AddToCart(Dictionary<string, Product.ProductInfo> products, Dictionary<string, int> cart)
        {
            Console.Write("Введите название продукта, который хотите добавить в корзину: ");
            string productName = Console.ReadLine()!;

            if (!products.TryGetValue(productName, out var product))
            {
                Console.WriteLine($"Продукт {productName} не найден.");
                return;
            }

            if (productName.Equals("Ктулху", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Ктулху нельзя купить. Но теперь он о вас знает...");
                return;
            }

            Console.Write($"Введите количество продукта {productName}, которое хотите добавить в корзину: ");
            if (int.TryParse(Console.ReadLine(), out int quantity))
            {
                if (quantity <= product.Quantity)
                {
                    cart[productName] = cart.TryGetValue(productName, out var currentQuantity)
                        ? currentQuantity + quantity
                        : quantity;

                    Console.WriteLine($"{quantity} единиц продукта {productName} добавлено в корзину.");
                }
                else
                {
                    Console.WriteLine($"Недостаточное количество продукта {productName} на складе.");
                }
            }
            else
            {
                Console.WriteLine("Некорректное количество.");
            }
        }

        public static void ShowCart(Dictionary<string, int> cart)
        {
            if (cart.Count == 0)
            {
                Console.WriteLine("Корзина пуста.");
                return;
            }

            Console.WriteLine("Содержимое корзины:");
            foreach (var kvp in cart)
            {
                Console.WriteLine($"Продукт: {kvp.Key}, Количество: {kvp.Value}");
            }
        }

        public static void BuyFromCart(Dictionary<string, Product.ProductInfo> products, Dictionary<string, int> cart)
        {
            List<string> productsToRemove = new List<string>();

            foreach (var kvp in cart)
            {
                var productName = kvp.Key;
                var cartQuantity = kvp.Value;

                if (cartQuantity > 0)
                {
                    var product = products[productName];
                    Console.WriteLine($"Вы купили {cartQuantity} единиц продукта {productName} за {cartQuantity * product.Price} единиц.");
                    product.Quantity -= cartQuantity;

                    if (product.Quantity == 0)
                    {
                        productsToRemove.Add(productName);
                    }
                }
                else
                {
                    Console.WriteLine($"Продукт {productName} не найден в корзине.");
                }
            }

            foreach (var productName in productsToRemove)
            {
                products.Remove(productName);
            }

            cart.Clear();
        }

        public static void AddNewProduct(Dictionary<string, Product.ProductInfo> products)
        {
            Console.Write("Введите название нового продукта: ");
            string productName = Console.ReadLine()!;

            Console.Write("Введите цену нового продукта: ");
            if (int.TryParse(Console.ReadLine(), out int price))
            {
                Console.Write("Введите количество нового продукта: ");
                if (int.TryParse(Console.ReadLine(), out int quantity))
                {
                    Product.ProductInfo newProduct = new Product.ProductInfo
                    {
                        Name = productName,
                        Price = price,
                        Quantity = quantity
                    };

                    if (!products.ContainsKey(productName))
                    {
                        products.Add(productName, newProduct);
                        Console.WriteLine($"Продукт {productName} добавлен.");
                    }
                    else
                    {
                        Console.WriteLine($"Продукт {productName} уже существует.");
                    }
                }
                else
                {
                    Console.WriteLine("Некорректный ввод количества.");
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод цены.");
            }
        }
    }
}
