using Calculates.Core;
using Calculates.DB;
using Microsoft.AspNetCore.Mvc;

namespace Calculator.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatesController : ControllerBase
    {
        private ICalculatesServices _calculatesServices;
        public CalculatesController(ICalculatesServices calculatesServices)
        {
            _calculatesServices = calculatesServices;
        }

        [HttpGet]
        public IActionResult GetCalculates()
        {
            return Ok(_calculatesServices.GetCalculates());
        }


        [HttpGet("{id}", Name = nameof(GetCalculate))]
        public IActionResult GetCalculate(int id)
        {
            return Ok(_calculatesServices.GetCalculate(id));
        }

        [HttpPost]
        public IActionResult CreateCalculate(Calculate calculate)
        {
            var newCalculate = _calculatesServices.CreateCalculate(calculate);
            return CreatedAtRoute(nameof(GetCalculate), new { newCalculate.Id }, newCalculate);
        }

        [HttpDelete]
        public IActionResult DeleteCalculate(Calculate calculate)
        {
            _calculatesServices.DeleteCalculate(calculate);
            return Ok();
        }

        [HttpPut]
        public IActionResult EditCalculate(Calculate calculate)
        {
            return Ok(_calculatesServices.EditCalculate(calculate));
        }
    }
}
