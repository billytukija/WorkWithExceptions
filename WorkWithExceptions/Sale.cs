using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithExceptions
{
        public class Sale
        {
            public int Id { get; set; }
            public DateTime Data { get; set; }
            public List<Product> Items { get; } = new List<Product>();

            public void AdicionarItem(Product item)
            {
                if (item == null)
                    throw new SaleException(999, "Item can not be null");
                Items.Add(item);
            }

            public decimal Sum()
            {
                return Items.Sum(i => i.Price * i.Quantity);
            }
        }
    }
