using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Data.Entity;
using IndustryConnect_Week5_WebApi.Dtos;
using IndustryConnect_Week5_WebApi.Mappers;
using IndustryConnect_Week5_WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;
using System.ComponentModel;

namespace IndustryConnect_Week5_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private readonly IndustryConnectWeek2Context _context;

        public CustomerController(IndustryConnectWeek2Context context)
        {
            _context = context;
        }


        // GET: api/Customer
        [HttpGet]
        public  List<Customer> GetCustomers()
        {
            if (_context.Customers != null) {

                return _context.Customers.ToList();
            }
            else
            {
                return null;
            }
        }

        // GET: api/Customer/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerDto>> GetCustomer(int id)
        {
            var customer = await _context.Customers.FindAsync(id);

            if (customer == null)
            {
                return NotFound();
            }

            return CustomerMapper.EntityToDto(customer);
        }



        

    }
}
