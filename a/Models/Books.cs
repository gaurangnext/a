using System;
using System.Collections.Generic;

namespace a.Models
{
    public partial class Books
    {
        public Books()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }

        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
