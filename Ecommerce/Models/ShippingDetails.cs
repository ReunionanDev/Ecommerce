using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce.Models
{
    public class ShippingDetails
    {
        /*public int Id { get; set; }
        public int CustomerId { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Zip { get; set; }
        public decimal OrderTotal { get; set; }
        public bool Deleted { get; set; }
        public System.DateTime CreatedOnUtc { get; set; }*/

        public int Id { get; set; }
        public System.Guid OrderGuid { get; set; }
        public int CustomerId { get; set; }
        public int BillingAddressId { get; set; }
        public Nullable<int> ShippingAddressId { get; set; }
        public decimal OrderTotal { get; set; }
        public bool Deleted { get; set; }
        public System.DateTime CreatedOnUtc { get; set; }
    }
}