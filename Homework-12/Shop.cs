using System.Collections.ObjectModel;

namespace Homework_12
{
    public class Shop
    {
        public ObservableCollection<Item> product = new ObservableCollection<Item>();

        public void Add(int id, string name)
        {
            product.Add(new Item(id, name));
        }
        public void Remove(int id)
        {
            product.RemoveAt(id);
        }
    }
}
