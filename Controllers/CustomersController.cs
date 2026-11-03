
using AcxiomCRM.Models;
using Microsoft.AspNetCore.Mvc;

namespace AcxiomCRM.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CustomersController : ControllerBase
{
    private static List<Customer> customers = new();
    private static int nextId = 1;

    [HttpGet]
    public IActionResult GetCustomers()
    {
        return Ok(customers);
    }

    [HttpPost]
    public IActionResult AddCustomer(Customer customer)
    {
        customer.Id = nextId++;
        customers.Add(customer);

        return Ok(customer);
    }

    [HttpGet("{id}")]
    public IActionResult GetCustomer(int id)
    {
        var customer = customers.FirstOrDefault(c => c.Id == id);

        if (customer == null)
            return NotFound();

        return Ok(customer);
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteCustomer(int id)
    {
        var customer = customers.FirstOrDefault(c => c.Id == id);

        if (customer == null)
            return NotFound();

        customers.Remove(customer);
        return Ok("Customer deleted successfully");
    }
}
