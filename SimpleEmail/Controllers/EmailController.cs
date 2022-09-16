using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MimeKit.Text;
using SimpleEmail.Model;
using SimpleEmail.Services;

namespace SimpleEmail.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailService _service;

        public EmailController(IEmailService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult SendEmail(/*string body*/ EmailDto dto)
        {
            /*
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse("wilfrid.bednar32@ethereal.email"));
            email.To.Add(MailboxAddress.Parse("wilfrid.bednar32@ethereal.email"));
            email.Subject = "Test Email";
            email.Body = new TextPart(TextFormat.Html)
            {
                Text = body
            };

            using(var smtp = new SmtpClient())
            {
                smtp.Connect("smtp.ethereal.email", 587, MailKit.Security.SecureSocketOptions.StartTls);
                smtp.Authenticate("wilfrid.bednar32@ethereal.email", "Bbf5zd7XqeXU4aQs3z");
                smtp.Send(email);
                smtp.Disconnect(true);

                return Ok("message sent");
            }
            */

            _service.SendEmail(dto);

            return Ok("Sent");
        }
    }
}
