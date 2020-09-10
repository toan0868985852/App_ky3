using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_02.Model
{
    public class NewsItem
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string HeadLine { get; set; }
        public string Subhead { get; set; }
        public string DateLine { get; set; }
        public string Image { get; set; }
       
    }

    public class NewManager
    {
        public static void GetNews( string category, ObservableCollection<NewsItem> newsItems)
        {
            var allItems = getNewsItems();

            var filteredNewsItems = allItems
                .Where(p => p.Category == category)
                .ToList();

            newsItems.Clear();

            filteredNewsItems.ForEach(p => newsItems.Add(p));
        }

        private static List<NewsItem> getNewsItems()
        {
            var items = new List<NewsItem>();

            items.Add(new NewsItem() { Id = 1, Category = "Financial", HeadLine = "Of there lineage but rake thy there in if was land deem thy his childe", Subhead = "Artless save mother drowsy coffined aye none harold cared finds caught but feels brow sing", DateLine = "", Image = "Assets/money1.jpg" });
            items.Add(new NewsItem() { Id = 2, Category = "Financial", HeadLine = "All dwelt condole soils muse and lemans or since ofttimes calm plain or a his", Subhead = "Where ever weary present charms the would hill to for not glare he domestic shell", DateLine = "", Image = "Assets/money2.png" });
            items.Add(new NewsItem() { Id = 3, Category = "Financial", HeadLine = "Times yea not misery heart peace call childe chill one for from known mote concubines", Subhead = "Neer ah unto he awake to his would passion drowsy had hill flow that memory", DateLine = "", Image = "Assets/money3.png" });
            items.Add(new NewsItem() { Id = 4, Category = "Financial", HeadLine = "They for deigned sad thence this feud his one himnot that thy his his whateer", Subhead = "With honeyed deem might deem lyres did wandered known relief and pollution from or apart", DateLine = "", Image = "Assets/money4.jpg" });
            items.Add(new NewsItem() { Id = 5, Category = "Financial", HeadLine = "Given childe he loathed scarce thee done loved memory in that his from in was", Subhead = "He have weary aisle but mote know childe a hellas come lines degree wrong scorching", DateLine = "", Image = "Assets/foot3.jpg" });

            items.Add(new NewsItem() { Id = 6, Category = "Food", HeadLine = "Of there lineage but rake thy there in if was land deem thy his childe", Subhead = "Artless save mother drowsy coffined aye none harold cared finds caught but feels brow sing", DateLine = "", Image = "Assets/chef.jpg" });
            items.Add(new NewsItem() { Id = 7, Category = "Food", HeadLine = "All dwelt condole soils muse and lemans or since ofttimes calm plain or a his", Subhead = "Where ever weary present charms the would hill to for not glare he domestic shell", DateLine = "", Image = "Assets/food.jpg" });
            items.Add(new NewsItem() { Id = 8, Category = "Food", HeadLine = "Times yea not misery heart peace call childe chill one for from known mote concubines", Subhead = "Neer ah unto he awake to his would passion drowsy had hill flow that memory", DateLine = "", Image = "Assets/food2.png" });
            items.Add(new NewsItem() { Id = 9, Category = "Food", HeadLine = "They for deigned sad thence this feud his one himnot that thy his his whateer", Subhead = "With honeyed deem might deem lyres did wandered known relief and pollution from or apart", DateLine = "", Image = "Assets/food4.png" });
            items.Add(new NewsItem() { Id = 10, Category = "Food", HeadLine = "Given childe he loathed scarce thee done loved memory in that his from in was", Subhead = "He have weary aisle but mote know childe a hellas come lines degree wrong scorching", DateLine = "", Image = "Assets/foot3.jpg" });

            return items;
        }
    }
}
