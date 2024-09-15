
namespace Bulky.Utility;

public class EmailSender : IEmailSender
{
    public Task SendEmailAsync(string email, string subject, string htmlMessage)
    {
        return Task.CompletedTask;
    }
}

public interface IEmailSender
{
    Task SendEmailAsync(string email, string subject, string htmlMessage);

}