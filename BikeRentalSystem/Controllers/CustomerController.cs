using AutoMapper;
using BikeRentalSystem.Models;
using BikeRentalSystem.Repository;
using BikeRentalSystem.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BikeRentalSystem.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IData data;
        private readonly IMapper mapper;

        public CustomerController(IData _data, IMapper _mapper)
        {
            data = _data;
            mapper = _mapper;
        }

        public IActionResult Login(object sender, EventArgs e)
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LoginBtn_Click(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Login", model);
            }
            else
            {
                var customer = data.GetAllCustomers().FirstOrDefault(c => c.Email == model.Email && c.Password == model.Password);
                if (customer == null)
                {
                    ModelState.AddModelError("", "Invalid login attempt.");
                    return View("Login", model);
                }

                var claims = new List<Claim>
                {
                    new Claim("Identifier", customer.Id.ToString()),
                    new Claim("name", customer.Name),
                    new Claim("email", customer.Email)
                };

                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                return RedirectToAction("Index", "HomeController");
            }
            
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // sprawdzenie, czy użytkownik o podanym adresie email już istnieje
            var existingUser = data.GetCustomerByEmail(model.Email);
            if (existingUser != null)
            {
                ModelState.AddModelError("", "Użytkownik o podanym adresie email już istnieje.");
                return View(model);
            }

            // utworzenie nowego użytkownika
            var newUser = new Customer
            {
                Name = model.Name,
                Address = model.Address,
                Email = model.Email,
                Password = model.Password,
                PhoneNumber = model.PhoneNumber,

            };

            // zapisanie nowego użytkownika w bazie danych
             data.AddCustomer(newUser);

            // przekierowanie do strony powitalnej po udanym rejestracji
            return RedirectToAction("Login");
        }
     
    }
}
