using WebApplication3.Interface;

namespace WebApplication3.Service
{
    public class FinanceService : IEmailService<FinanceService>
    {
        public string SendEmail()
        {
            return "Finace Email Send";
        }
    }
}
