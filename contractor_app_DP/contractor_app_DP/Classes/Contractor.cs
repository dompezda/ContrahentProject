using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace contractor_app_DP.Classes
{
    public class Contractor
    {
        [Key]
        public int ContractorId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public int REGON { get; set; }
        public int NIP { get; set; }

        public int ContactNumber { get; set; }

        public int AddressId { get; set; }
        public virtual Address Address { get; set; }

    }
}
