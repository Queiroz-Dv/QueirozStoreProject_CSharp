using System;
using System.Collections.Generic;

namespace QueirozStore.Domain.QueirozStore.Context.Entities
{
  public class Order
  {
    public Customer Customer { get; set; }
    public string Number { get; set; }
    public DateTime CreateDate { get; set; }
    public bool Status { get; set; }
    public IList<OrderItem> Items { get; set; }
    public IList<Delivery> Deliveries { get; set; }

    public void Place()
    {

    }
    
  }
}