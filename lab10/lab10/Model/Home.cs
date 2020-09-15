using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10.Model
{
    public class Home
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Content { get; set; }
    }


    public class NewManager
    {

        public static void GetNews(string category, ObservableCollection<Home> newsItems)
        {
            var allItems = getNewsItems();

            var filteredNewsItems = allItems
                .Where(p => p.Category == category)
                .ToList();

            newsItems.Clear();

            filteredNewsItems.ForEach(p => newsItems.Add(p));
        }

        private static List<Home> getNewsItems()
        {
            var items = new List<Home>();

            items.Add(new Home() { Id = 1, Category = "Home", Title = "Ever nor control in memory", Content = "Save up to 50% Forza game",  Image = "Assets/1.jpg" });
            items.Add(new Home() { Id = 2, Category = "Home", Title = "Know shell me through ere sister", Content = "The had who will if befell and low", Image = "Assets/4.jpg" });
            items.Add(new Home() { Id = 3, Category = "Home", Title = "Done harold still plain and childe", Content ="Would he isle mine native his each can nine", Image = "Assets/3.jpg" });
            items.Add(new Home() { Id = 4, Category = "Home", Title = "Ever nor control in memory", Content = "That be childe of like chill men disporting", Image = "Assets/9.jpg" });
            items.Add(new Home() { Id = 5, Category = "Home", Title = "Oft nine nor fall mammon fountain", Content = "Of now ere to congealed childe to nor", Image = "Assets/5.jpg" });
            items.Add(new Home() { Id = 6, Category = "Home", Title = "Ever nor control in memory", Content = "Known unto the it few to goodly stalked not", Image = "Assets/6.jpg" });
            items.Add(new Home() { Id = 7, Category = "Home", Title = "Oft nine nor fall mammon fountain", Content = "Loved fellow condole seemed the in and made", Image = "Assets/7.jpg" });
            items.Add(new Home() { Id = 8, Category = "Home", Title = "Know shell me through ere sister", Content = "Pleasure nor cheer stalked name his awake did", Image = "Assets/8.jpg" });

            items.Add(new Home() { Id = 9, Category = "Game", Title = "At soils een some the mote", Content = "Save up to 50% Forza game", Image = "Assets/3.jpg" });
            items.Add(new Home() { Id = 10, Category = "Game", Title = "Or of hight not of from flash", Content = "Strange artless these clay to found to within", Image = "Assets/6.jpg" });
            items.Add(new Home() { Id = 11, Category = "Game", Title = "And native below to now none glee", Content = "The mood by deigned paphian dwelt in sun ungodly", Image = "Assets/1.jpg" });
            items.Add(new Home() { Id = 12, Category = "Game", Title = "Fame with shun wins sighed for but", Content = "And whose from did saw he shamed within", Image = "Assets/7.jpg" });
            items.Add(new Home() { Id = 13, Category = "Game", Title = "Neer holy girls lyres not that yet", Content = "Not of fall if to been fathers yes his", Image = "Assets/8.jpg" });
            items.Add(new Home() { Id = 14, Category = "Game", Title = "Oft nine nor fall mammon fountain", Content = "Nor at condole coffined can soils minstrels been", Image = "Assets/9.jpg" });
            items.Add(new Home() { Id = 15, Category = "Game", Title = "Fame with shun wins sighed for but", Content = "Did noontide hall childe knew had honeyed", Image = "Assets/1.jpg" });
            items.Add(new Home() { Id = 16, Category = "Game", Title = "Oft nine nor fall mammon fountain", Content = "Sullen which when for all deigned whateer far", Image = "Assets/5.jpg" });

            return items;
        }
    }
}
