using System;
using System.Collections.Generic;

namespace a.Models
{
    public partial class OrderDetails
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int OrderId { get; set; }
        public int BookId { get; set; }

        public virtual Books Book { get; set; }
        public virtual Orders Order { get; set; }
    }
}
