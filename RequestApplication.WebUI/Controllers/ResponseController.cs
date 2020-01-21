using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RequestApplication.BLL.Abstract;
using RequestApplication.Entitiy;
using RequestApplication.WebUI.Models;
using static System.Net.Mime.MediaTypeNames;

namespace RequestApplication.WebUI.Controllers
{

    [Authorize(Roles = "Admin")]
    public class ResponseController : Controller
    {
        private readonly IRequestBLL _requestBLL;
        private readonly IMapper _mapper;
        private readonly IMailBLL _mailBLL;
        private readonly IDocumentBLL _documentBLL;

        public ResponseController(IRequestBLL requestBLL, IMapper mapper, IMailBLL mailBLL, IDocumentBLL documentBLL)
        {
            _requestBLL = requestBLL;
            _mapper = mapper;
            _mailBLL = mailBLL;
            _documentBLL = documentBLL;
        }

        public IActionResult List()
        {
            var responses = _requestBLL.GetAllRequests().OrderByDescending(a => a.RequestDate).ToList();

            var model = _mapper.Map<List<ResponseListViewModel>>(responses);

            return View(model);
        }
        [HttpGet]

        public IActionResult Answer(int id)
        {
            var response = _requestBLL.GetRequest(id);

            var model = _mapper.Map<ResponseAnswerViewModel>(response);

            return View(model);
        }
        [HttpPost]

        public IActionResult Answer(ResponseAnswerViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // Cookie'de olan user'ın Id'sini alıyoruz

            var adminId = User.Claims.Where(a => a.Type == ClaimTypes.NameIdentifier).Select(a => a.Value).FirstOrDefault();

            model.AdminId = Convert.ToInt32(adminId);

            var request = _mapper.Map<Request>(model);

            _requestBLL.UpdateRequest(request);

            _mailBLL.SendMail(request);

            return RedirectToAction("List");
        }

        public IActionResult Download(string id)
        {
            var document = _documentBLL.Download(id);

            return File(document, "application/force-download", id);
        }

        public IActionResult Report(int id)
        {
            var report = _documentBLL.Report(id);

            return File(report, "application/force-download", "report.txt");
        }


    }
}