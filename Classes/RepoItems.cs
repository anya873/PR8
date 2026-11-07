using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Shapovalova.Classes
{
    public class RepoItems
    {
        public static List<object> AllItems()
        {
            List<object> allItems = new List<object>();
            allItems.Add(new Children("Игрушка интерактивная", 2200, 3));
            allItems.Add(new Children("Кактус танцующий", 894, 6));
            allItems.Add(new Children("Мягкая игрушка кошка подушка", 1754, 6));
            allItems.Add(new Sport("Спортивный мужской костюм", 2200, "S"));
            allItems.Add(new Sport("Мяч для водного поло", 2200, "61-63 см"));
            allItems.Add(new Sport("Набор для гольфа Partida", 2200, "600*800 мм"));
            allItems.Add(new Electronic("Часы", 10000, "5000 mAh", "60 Г/с"));
            allItems.Add(new Electronic("Наушники",3000, "4500 mAh", "50 Г/с"));
            allItems.Add(new Electronic("Телефон", 50000, "6000 mAh", "120 Г/с"));
            return allItems;
        }
    }
}
