using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddressInMemory.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string PersonName { get; set; }
        public string FlateNo { get; set; }
        public string BuildingNo { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PinCode { get; set; }
    }
}
