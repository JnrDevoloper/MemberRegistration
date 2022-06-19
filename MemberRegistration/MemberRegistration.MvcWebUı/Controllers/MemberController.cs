using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.ExceptionHandling;
using System.Web.Mvc;
using MemberRegistration.Business.Abstract;
using MemberRegistration.Entities.Concrete;
using MemberRegistration.MvcWebUı.Filters;
using MemberRegistration.MvcWebUı.Models;

namespace MemberRegistration.MvcWebUı.Controllers
{
    public class MemberController : Controller
    {
        private IMemberService _memberService;

        public MemberController(IMemberService memberService)
        {
            _memberService = memberService;
        }

        public ActionResult Add()
        {
            return View(new MemberAddViewModel());
        }
        [HttpPost]
        [ExecptionHandler]
        public ActionResult Add(Member member)
        {
            _memberService.Add(member);

            return View(new MemberAddViewModel());
        }
    }
}