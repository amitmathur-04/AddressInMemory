using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AddressInMemory.Models;

namespace AddressInMemory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressesController : ControllerBase
    {
        private readonly APIContext _context;

        public AddressesController(APIContext context)
        {
            _context = context;
        }

        // GET: api/Addresses
        [HttpGet]
        public ActionResult<IEnumerable<Address>> GetAddressess()
        {
            List<Address> addresses = _context.GetAllAddreeess();
            return Ok(addresses);
        }

        // GET: api/Addresses/PersonName
        [HttpGet("{name}", Name = "GetByName")]
        public ActionResult<Address> GetAddressBbyName(string name)
        {
            var addresses = _context.GetAddrressByName(name);
            return Ok(addresses);
        }

        // PUT: api/Addresses/5
        [HttpPut("{name}")]
        public IActionResult PutAddress(string name, [FromBody] Address address)
        {
            if (name != address.PersonName)
            {
                return BadRequest();
            }
            if (!_context.AddressExists(name))
            {
                return NotFound();
            }

            var addresses = _context.UpdateAddrress(address);
            return Ok(addresses);
        }

        // POST: api/Addresses
        [HttpPost]
        public ActionResult<Address> PostAddress([FromBody] Address address)
        {
            if (address == null)
            {
                return BadRequest();
            }
            var addresses = _context.AddAddrress(address);
            return Ok(addresses);
        }

        // DELETE: api/Addresses/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Address>> DeleteAddress(int id)
        {
            var address = await _context.Addressess.FindAsync(id);
            if (address == null)
            {
                return NotFound();
            }

            _context.Addressess.Remove(address);
            await _context.SaveChangesAsync();

            return address;
        }

        //private bool AddressExists(string name)
        //{
        //    return _context.Addressess.Any(e => e.PersonName.Equals(name));
        //}
    }
}
