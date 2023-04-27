using System.Collections;
using System.Collections.Specialized;
using System.Runtime.Serialization;

namespace Homework_12
{
    public class Customer
    {
        public static void OnItemChanged(NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    Console.WriteLine($"Был добавлен товар {Formatted(e.NewItems)}");
                    
                    break;
                case NotifyCollectionChangedAction.Remove:
                    Console.WriteLine($"Был удалён товар {Formatted(e.OldItems)}");
                    break;
            }
        }

        private static string Formatted(IList values)
        {
            Item a = (Item)values[0];
            return $"Id - {a.Id} Товар от - {a.Name}";
        }

    }
}
