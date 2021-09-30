using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace contractor_app_DP.Classes
{
    public class RegisterModel
    { 
        [Key]
        public int ContractorId { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public string HomeNumber { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public int REGON { get; set; }
        public int NIP { get; set; }
        public int ContactNumber { get; set; }
    }

}
