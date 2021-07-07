using System.Threading.Tasks;

namespace Prueba4.Models.Services
{
    public interface IMailService
    {
        Task SendEmailAsync(MailRequest mailRequest);
    }
}