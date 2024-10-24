using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace goods
{
    public class Sales
    {
        private Dictionary<Groups, List<Sale>> history_;

        public struct Sale
        {
            public int date { get; set; }
            public Good good { get; set; }
            public int quantity { get; set; }
        }

        public void AddSale(int date, Good good, int quantity)
        {
            // Создаём продажу
            Sale sale = new Sale { date = date, good = good, quantity = quantity };

            // Проверяем, есть ли запись для этой группы
            Groups group = good.GetGroup();
            if (!history_.ContainsKey(group))
                history_.Add(group, new List<Sale>());

            // Добавляем запись продажи
            history_[group].Add(sale);
        }
    }
}
