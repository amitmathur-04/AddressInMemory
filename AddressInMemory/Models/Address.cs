using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AddressInMemory.Models
{
    public class Address
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string PersonName { get; set; }

        [Required]
        [MaxLength(8)]
        public string FlateNo { get; set; }

        [Required]
        [MaxLength(5)]
        public string BuildingNo { get; set; }

        public string StreetName { get; set; }

        [Required]
        [MaxLength(15)]
        public string City { get; set; }

        [Required]
        [MaxLength(30)]
        public string State { get; set; }

        [Required]
        [MaxLength(15)]
        public string PinCode { get; set; }
    }
}
