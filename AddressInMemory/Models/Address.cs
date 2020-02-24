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
        [MaxLength(50, ErrorMessage ="Max characters of Person Name can be 50 only")]
        [RegularExpression(@"[a-zA-Z]+\\s",ErrorMessage ="Person Name should have only alphaets")]
        public string PersonName { get; set; }

        [Required]
        [MaxLength(8,ErrorMessage = "Flat No can have 8 characters as max length")]
        [RegularExpression(@"[a-zA-Z0-9-]+\\s", ErrorMessage = "Flat No. can have alphanumeric and - characters")]
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
