using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Interface;
using WebApplication3.Service;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FinanceController : ControllerBase
    {
        private readonly IEmailService<FinanceService> _emailService;

        public FinanceController(IEmailService<FinanceService> emailService)
        {
            _emailService = emailService;
        }

        /// <summary>
        /// send finance mail
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("sendEmail")]
        public IActionResult SendEmail()
        {
            var result = _emailService.SendEmail();
            return Ok(result);
        }
    }
}
