namespace Article
{
    public class Article
    {
        public Article(string name, string store, double price)
        {
            Name = name;
            Store = store;
            Price = price;
        }

        public string Name { get; }
        public string Store { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"Name = {Name}, store = {Store}, price = {Price}";
        }

    }
}
