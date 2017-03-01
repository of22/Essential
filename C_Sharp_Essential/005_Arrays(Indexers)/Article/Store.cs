namespace Article
{
    using System;

    public class Store
    {
        const string NotFoundText = "Such article isn't found";

        public readonly Article[] Articles;
        public static int Counter;

        public Store(int size)
        {
            Articles = new Article[size];
        }

        public string this[string key]
        {
            get
            {
                try
                {
                    foreach (var article in Articles)
                    {
                        if (article.Name.ToLower().Equals(key.ToLower()))
                        {
                            return article.ToString();
                        }

                    }
                }
                catch (Exception)
                {
                    return NotFoundText;
                }

                return NotFoundText;
            }
        }
        public string this[int index]
        {
            get
            {
                try
                {
                    if (Articles[index] != null)
                    {
                        return Articles[index].ToString();
                    }
                }
                catch (Exception)
                {
                    return NotFoundText;
                }
                return NotFoundText;
            }
        }

        public void AddArticle(string name, string store, double price)
        {
            if (Counter < 0 || Counter >= Articles.Length)
            {
                throw new Exception("Counter is out of array bounds");
            }
            if (name.Length > 1 & store.Length > 1 & price > 0)
            {
                Articles[Counter] = new Article(name, store, price);
            }
            Counter++;
        }
    }
}
