using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace contractor_app_DP.Classes
{
    public class Address
    {

        [Key]
        public int AddressId { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public string HomeNumber { get; set; }

    }
}
