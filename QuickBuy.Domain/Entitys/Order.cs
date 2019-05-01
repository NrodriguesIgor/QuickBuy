using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Domain.Entitys
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
