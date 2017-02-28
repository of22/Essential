namespace Article
{
    public class Store
    {
        //• вывод информации о товаре по номеру с помощью индекса; 
        //• вывод на экран информации о товаре, название которого введено с клавиатуры, если таких товаров нет, выдать соответствующее сообщение; 
        //Написать программу, вывода на экран информацию о товаре.

        const string NotFoundText = "Such article isn't found";

        public readonly Article[] Articles;
        public static int Сounter;
     
        public Store(int size)
        {
            Articles = new Article[size];
        }

        public string this[string key]
        {
            get
            {
                foreach (var article in Articles)
                {
                    if (article.Name.ToLower().Equals(key.ToLower()))
                    {
                        return article.ToString();
                    }
                }
                return NotFoundText;
            }
        }
        public string this[int index]
        {
            get
            {
                if (Articles[index] != null)
                {
                    return Articles[index].ToString();
                }
                return NotFoundText;
            }
        }

        public void AddArticle(string name, string store, double price)
        {
            if ( name.Length > 1 & store.Length > 1 & 
                )
            {
                
            }
            Articles[Сounter] = new Article(name, store, price);

            Сounter++;
        }


    }
}
