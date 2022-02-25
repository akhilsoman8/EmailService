using WebApplication3.Interface;

namespace WebApplication3.Service
{
    public class AdminService : IEmailService<AdminService>
    {
        public string SendEmail()
        {
            return "Admin Email Send";
        }
    }
}
