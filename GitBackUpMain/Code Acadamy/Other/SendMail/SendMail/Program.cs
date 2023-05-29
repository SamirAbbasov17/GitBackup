using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SendMail.Models;
using System.Net.Mail;


await new HostBuilder().ConfigureServices((hostContext, services) =>
{
    services.AddHostedService<Mail>();
}).RunConsoleAsync();

