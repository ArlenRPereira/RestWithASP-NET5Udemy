using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace RestWithASPNET5Udemy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{firstNumber}/{secoundNumber}")]
        public IActionResult Sum(string firstNumber, string secoundNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secoundNumber))
            {
                var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secoundNumber);
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid Input");
        }

        [HttpGet("subtraction/{firstNumber}/{secoundNumber}")]
        public IActionResult Subtraction(string firstNumber, string secoundNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secoundNumber))
            {
                var subtraction = ConvertToDecimal(firstNumber) - ConvertToDecimal(secoundNumber);
                return Ok(subtraction.ToString());
            }
            return BadRequest("Invalid Input");
        }

        [HttpGet("multiplication/{firstNumber}/{secoundNumber}")]
        public IActionResult Multiplication(string firstNumber, string secoundNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secoundNumber))
            {
                var multiplication = ConvertToDecimal(firstNumber) * ConvertToDecimal(secoundNumber);
                return Ok(multiplication.ToString());
            }
            return BadRequest("Invalid Input");
        }

        [HttpGet("division/{firstNumber}/{secoundNumber}")]
        public IActionResult Division(string firstNumber, string secoundNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secoundNumber))
            {
                var division = ConvertToDecimal(firstNumber) / ConvertToDecimal(secoundNumber);
                return Ok(division.ToString());
            }
            return BadRequest("Invalid Input");
        }

        [HttpGet("mean/{firstNumber}/{secoundNumber}")]
        public IActionResult Mean(string firstNumber, string secoundNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secoundNumber))
            {
                var mean = (ConvertToDecimal(firstNumber) + ConvertToDecimal(secoundNumber)) / 2;
                return Ok(mean.ToString());
            }
            return BadRequest("Invalid Input");
        }

        [HttpGet("square-root/{firstNumber}")]
        public IActionResult SquareRoot(string firstNumber)
        {
            if (IsNumeric(firstNumber))
            {
                var squareRoot = Math.Sqrt((double)ConvertToDecimal(firstNumber));
                return Ok(squareRoot.ToString());
            }
            return BadRequest("Invalid Input");
        }

        private bool IsNumeric(string strNumber)
        {
            double number;
            bool isNumber = double.TryParse(
                strNumber,
                System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo,
                out number);
            return isNumber;
        }

        private decimal ConvertToDecimal(string strNumber)
        {
            decimal decimalValue;
            if (decimal.TryParse(strNumber, out decimalValue))
            {
                return decimalValue;
            }
            return 0;
        }
        
    }
}
