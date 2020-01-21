using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RequestApplication.BLL.Abstract;
using RequestApplication.Entitiy;
using RequestApplication.WebUI.Models;

namespace RequestApplication.WebUI.Controllers
{
    [Authorize(Roles = "User")]
    public class RequestController : Controller
    {
        private readonly IRequestBLL _requestBLL;
        private readonly IMapper _mapper;
        public RequestController(IRequestBLL requestBLL, IMapper mapper)
        {
            _requestBLL = requestBLL;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(RequestCreateViewModel model, IFormFile document)
        {
            if (!ModelState.IsValid)
            {

                return View(model);
            }

            else
            {
                if (document != null)
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\document", document.FileName);

                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await document.CopyToAsync(stream);

                        model.Document = document.FileName;
                    }
                }
                else
                {
                    ModelState.AddModelError("FileError", "Dosya alanı zorunludur");
                    return View();
                }

                var userId = User.Claims.Where(a => a.Type == ClaimTypes.NameIdentifier).Select(a => a.Value).FirstOrDefault();

                model.UserId = Convert.ToInt32(userId);
    
                var request = _mapper.Map<Request>(model);

                _requestBLL.AddRequest(request);

                return RedirectToAction("List");
            }
        }
        public IActionResult Details(int id)
        {

            var userId = User.Claims.Where(a => a.Type == ClaimTypes.NameIdentifier).Select(a => a.Value).FirstOrDefault();

            if (_requestBLL.GetRequest(id).UserId == Convert.ToInt32(userId))
            {
                var request = _requestBLL.GetRequest(id);

                var model = _mapper.Map<RequestDetailsViewModel>(request);

                return View(model);
            }

            return RedirectToAction("AccessDenied", "Account");
            
        }
        public IActionResult List()
        {
            var userEmail = User.Claims.Where(a => a.Type == ClaimTypes.Email).Select(a => a.Value).FirstOrDefault();

            var requests = _requestBLL.GetAllRequests().Where(a => a.User.Email == userEmail).ToList();

            var model = _mapper.Map<List<RequestListViewModel>>(requests);

            return View(model);
        }


    }
}