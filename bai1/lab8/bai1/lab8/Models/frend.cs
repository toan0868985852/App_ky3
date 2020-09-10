using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8.Models
{

    public class Frend
    {
        public int FrendId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Address { get; set; }
        public string FavoriteFood { get; set; }
    }

    class FrendManager
    {
        public static List<Frend> GetFrends()
        {
            var frends = new List<Frend>();

            frends.Add(new Frend { FrendId = 1, Name = "A", Address = "Hà Nội", Image = "Assets/female-01.png", FavoriteFood = "Trứng" });
            frends.Add(new Frend { FrendId = 2, Name = "B", Address = "Hải Phòng", Image = "Assets/female-02.png", FavoriteFood = "Cơm" });
            frends.Add(new Frend { FrendId = 3, Name = "C", Address = "Hồ Chí Minh", Image = "Assets/female-03.png", FavoriteFood = "Mỳ" });
            frends.Add(new Frend { FrendId = 4, Name = "D", Address = "Bắc Giang", Image = "Assets/male-01.png", FavoriteFood = "Bánh Mỳ" });
            frends.Add(new Frend { FrendId = 5, Name = "E", Address = "Hà Tĩnh", Image = "Assets/male-02.png", FavoriteFood = "Cua" });
            frends.Add(new Frend { FrendId = 6, Name = "F", Address = "Hà Nội", Image = "Assets/male-03.png", FavoriteFood = "Thịt" });
          

            return frends;
        }
    }
}
