using AwesomeShop.Services.Notifications.Api.Infrastructure.Dtos;
using System.Threading.Tasks;

namespace AwesomeShop.Services.Notifications.Infrastructure.Persistence.Repositories
{
    public interface IMailRepository
    {
        Task<EmailTemplateDto> GetTemplate(string @event);
    }
}
