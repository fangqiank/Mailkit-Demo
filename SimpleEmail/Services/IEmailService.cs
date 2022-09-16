using SimpleEmail.Model;

namespace SimpleEmail.Services
{
    public interface IEmailService
    {
        void SendEmail(EmailDto dto);
    }
}