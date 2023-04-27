namespace Homework_12
{
    public class Item
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public Item(int _id, string _name)
        {
            Id = _id;
            Name = _name;
        }
    }
}
