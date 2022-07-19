﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculator_Logic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Calculator_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ILogger<CalculatorController> _logger;
        private readonly Calculator calc;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
            calc = new Calculator();
        }

        // Create an API route for addition operation via HttpGet request
        // with left and right query params specified on the HttpRequest URL
        [HttpGet]
        [Route("add/{left}/{right}")]
        public double Add(double left, double right)
        {
            return calc.Add(left, right);
        }
    }
}

