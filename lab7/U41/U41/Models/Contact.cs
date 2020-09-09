using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using U41.Models;

namespace U41.Models
{
    public class Contacts
    {
        public static List<Icon> GetIcons()
        {
            var avatar = new List<Icon>();

            avatar.Add(new Icon { BookId = 1, Avatar = "Assets/female-01.png" });
            avatar.Add(new Icon { BookId = 2, Avatar = "Assets/female-02.png" });
            avatar.Add(new Icon { BookId = 3, Avatar = "Assets/female-03.png" });
            avatar.Add(new Icon { BookId = 4, Avatar = "Assets/male-01.png" });
            avatar.Add(new Icon { BookId = 5, Avatar = "Assets/male-02.png" });
            avatar.Add(new Icon { BookId = 6, Avatar = "Assets/male-03.png" });

            return avatar;
        }
    }
}
