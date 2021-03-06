﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MBAM.Annotations.Presentation.Controllers
{
    [Route("Home")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
