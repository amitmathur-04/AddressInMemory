using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddressInMemory.Validations
{
    public class APIContext : DbContext
    {
        public DbSet<Address> Addressess { get; set; }

        public APIContext()
        { }

        public APIContext(DbContextOptions<APIContext> context) : base(context)
        {
            LoadAddressess();
        }

        public void LoadAddressess()
        {
            Address address = new Address() { PersonName = "Vinay", FlateNo = "308", BuildingNo = "A-3", StreetName = "M G Road", City = "Pune", State = "Maharashtra", PinCode = "411036" };
            Addressess.Add(address);
            address = new Address() { PersonName = "Mahesh", FlateNo = "802", BuildingNo = "B-6", StreetName = "F C Road", City = "Pune", State = "Maharashtra", PinCode = "411036" };
            Addressess.Add(address);
        }

        public List<Address> GetAllAddreeess()
        {
            return Addressess.Local.ToList<Address>();
        }
        public Address GetAddrressByName(string name)
        {
            return Addressess.Local.ToList<Address>().FirstOrDefault(obj => obj.PersonName.Equals(name));
        }

        public List<Address> AddAddrress(Address address)
        {
            Addressess.Add(address);
            SaveChanges();
            return Addressess.Local.ToList<Address>();
        }

        public List<Address> UpdateAddrress(Address address)
        {
            //Entry(address).State = EntityState.Modified;

            var objAddress = GetAddrressByName(address.PersonName);
            objAddress.PersonName = address.PersonName;
            objAddress.Id = address.Id;
            objAddress.FlateNo = address.FlateNo;
            objAddress.StreetName = address.StreetName;
            objAddress.BuildingNo = address.BuildingNo;
            objAddress.City = address.City;
            objAddress.State = address.State;
            objAddress.PinCode = address.PinCode;
            SaveChanges();
            return Addressess.Local.ToList<Address>();
        }
        public bool AddressExists(string name)
        {
            return Addressess.Local.Any(e => e.PersonName.Equals(name));
        }
    }
}
