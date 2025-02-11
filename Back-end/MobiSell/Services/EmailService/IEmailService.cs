using MobiSell.Models;
namespace MobiSell.Services.EmailService
{
    public interface IEmailService
    {
        void SendEmail(EmailDTO request);
    }
}
