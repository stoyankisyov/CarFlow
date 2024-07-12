using CarFlow.DomainServices.IService;
using CarFlow.UI.Mappers;
using CarFlow.UI.Models.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace CarFlow.UI.Controllers
{
    public class AccountController(IAccountService accountService) : Controller
    {
        [HttpGet]
        public IActionResult SignUp()
        {
            if (User.Identity!.IsAuthenticated)
            {
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(AccountViewModel account)
        {
            if (!ModelState.IsValid)
            {
                return View(account);
            }

            await accountService.AddAccountAsync(account.ToDomainModel());

            return RedirectToAction(nameof(HomeController.Index), "Home");
        }

        [HttpGet]
        public IActionResult SignIn()
        {
            if (User.Identity!.IsAuthenticated)
            {
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(SignInViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var claimsPrincipal = await accountService.AuthenticateAsync(model.Email, model.Password);

            if (claimsPrincipal is null)
            {
                ModelState.AddModelError(string.Empty, "Invalid login attempt.");

                return View(model);
            }

            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                claimsPrincipal);

            return RedirectToAction(nameof(HomeController.Index), "Home");
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction(nameof(SignIn), "Account");
        }
    }
}
