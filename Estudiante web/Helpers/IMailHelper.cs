using Soccer.Common.Models;
using Soccer.web.Modelss;
namespace Soccer.web.Helpers
{
    public interface IMailHelper
    {
        Response SendMail(string to, string subject, string body);

    }
}
