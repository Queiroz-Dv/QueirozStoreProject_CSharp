using System;

namespace QueirozStore.Domain.QueirozStore.Context
{
  public class Delivery
    {
        public DateTime CreateDate { get; set; }
        public DateTime EstimatedDate { get; set; }
        public string Status { get; set; }
    }
}