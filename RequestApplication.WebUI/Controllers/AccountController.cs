using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RequestApplication.BLL.Abstract;
using RequestApplication.Entitiy;
using RequestApplication.WebUI.Models;

namespace RequestApplication.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserBLL _userBLL;
        private readonly IMapper _mapper;
        public AccountController(IUserBLL userBLL, IMapper mapper)
        {
            _userBLL = userBLL;
            _mapper = mapper;
        }


        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {

            var user = _mapper.Map<User>(model);

            var loginUser = _userBLL.GetUserFilter(user);


            if (loginUser != null)
            {
                var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Email, loginUser.Email),
                    new Claim(ClaimTypes.Role, loginUser.Roles.Name),
                    new Claim(ClaimTypes.NameIdentifier, loginUser.Id.ToString()),
                };

                var userIdentity = new ClaimsIdentity(claims, "login");

                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);

                await HttpContext.SignInAsync(principal);

                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("UserPasswordError", "Kullanıcı adı veya şifre hatalı");
                return View();
            }

        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            else
            {
                if (_userBLL.GetUserByEmail(model.Email) != null)
                {
                    ModelState.AddModelError("UserEmailContains", "Bu email daha önceden alınmış");
                    return View();
                }
                else
                {
                    var user = _mapper.Map<User>(model);

                    _userBLL.AddUser(user);

                    return View("Completed", model);

                }
            }


        }

        public IActionResult AccessDenied()
        {
            return View();
        }

    }
}