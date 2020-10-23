﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserAuthProject.Services.Interfaces;

namespace UserAuthProject.Controllers
{
    [Route("api/[controller]")]
    public class ControlPanelController : AuthorizedController
    {
        public ControlPanelController(IAuthenticationService authenticationService) : base(authenticationService)
        {
        }

        [HttpGet]
        public IActionResult Index()
        {
            if (!IsAuthenticated())
            {
                return RedirectToAction("Index", "Login");
            }
            return View();
        }

    }
}