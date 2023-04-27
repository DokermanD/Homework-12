namespace Homework_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Магазин
            Shop shop = new Shop();
            //Покупатель
            Customer customer = new Customer();

            //Подписываемся на изменения коллекции товаров
            shop.product.CollectionChanged += Product_CollectionChanged;

            var inputUser = string.Empty;
            while (true)
            {
                inputUser = Console.ReadLine();
                switch (inputUser)
                {
                    case "A" or "a":
                        shop.Add(shop.product.Count, DateTime.Now.ToString());
                        break; 
                    case "D" or "d":
                        Console.WriteLine("Какой товар надо удалить ?");
                        var id = Console.ReadLine();
                        shop.Remove(Convert.ToInt32(id));
                        break;
                    case "X" or "x":
                        Environment.Exit(0);
                        break;
                }
            }
        }

        
        private static void Product_CollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            Customer.OnItemChanged(e);
        }
    }
}