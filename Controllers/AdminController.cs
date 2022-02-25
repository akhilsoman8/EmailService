using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Interface;
using WebApplication3.Service;

namespace WebApplication3.Controllers
{

   
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IEmailService<AdminService> _emailService;

        public AdminController(IEmailService<AdminService> emailService)
        {
            _emailService = emailService;
        }

        /// <summary>
        /// send admin mail
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
