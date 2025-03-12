using BankTemplate.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using Services;

namespace BankTemplate.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ICustomerService _customerService;
        public List<CustomerViewModel> Customers { get; set; }

        public IndexModel(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public void OnGet()
        {
            Customers = _customerService.GetCustomers()
                .Select(c => new CustomerViewModel
            {
                Id = c.CustomerId,
                Name = c.Givenname,
            }).ToList();
        }
    }
}
