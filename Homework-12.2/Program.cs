using System.Collections.Concurrent;
using static System.Reflection.Metadata.BlobBuilder;

namespace Homework_12._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConcurrentDictionary<string, int> books = new ConcurrentDictionary<string, int>();
            //Поток для %
            TaskRanPercent();

            while (true)
            {
                ShowMenu();
                var key = Console.ReadLine();

                switch (key)
                {
                    case "1":
                        //Добавить книгу
                        Console.WriteLine("Введите название книги:");
                        var book = Console.ReadLine().ToString();
                        //Проверка при добавлении
                        if (!books.ContainsKey(book)) books.TryAdd(book, 0);
                        else Console.WriteLine("Такая книга уже есть в списке!");
                        break;

                    case "2":
                        //Вывести список непрочитанного
                        foreach (var item in books)
                        {
                            Console.WriteLine($"{item.Key} - {item.Value}%");
                        }
                        break;
                    case "3":
                        //Выход
                        Environment.Exit(0);
                        break;
                }
            }

            void TaskRanPercent()
            {
                Task.Run(async () =>
                {
                    while (true)
                    {
                        if (books.Count != 0)
                        {
                            foreach (var item in books)
                            {
                                books.TryUpdate(item.Key, item.Value + 1, item.Value);

                                if (item.Value >= 100)
                                {
                                    books.TryRemove(item.Key, out var d);
                                }
                            }
                        }
                        await Task.Delay(1000);
                    }
                   
                });
            }

            void ShowMenu()
            {
                Console.WriteLine("1 - добавить книгу;\n2 - вывести список непрочитанного;\n3 - выйти;\n");
            }
        }

       

       
    }
}