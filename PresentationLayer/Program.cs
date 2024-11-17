using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PresentationLayer.Forms;
using PresentationLayer.LoginF;
using QuestPDF.Infrastructure;

namespace PresentationLayer
{
    internal static class Program
    {
        /// <summary>
        /// 
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            QuestPDF.Settings.License = LicenseType.Community;
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<LoginForms>());
        }

        public static IServiceProvider ServiceProvider { get; private set; }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration((context, config) =>
                {
                    //config.AddJsonFile(
                    //    "appsettings.json",
                    //    optional: false,
                    //    reloadOnChange: true
                    // );
                })
                .ConfigureServices((context, services) =>
                {

                    //Forms
                    services.AddTransient<dashboardAdmin>();
                    services.AddTransient<LoginForms>();

                    //Repositories
                    services.AddScoped<IMatchRepository, MatchRepository>();
                    //services.AddScoped<IEmailQueueRepository, EmailQueueRepository>();

                    services.AddScoped<IUserRepository, UserRepository>();
                    //Services
                    services.AddScoped<IMatchService, MatchService>();
                    services.AddScoped<IUserService, UserService>();

                    //services.AddScoped<IEmailService, EmailService>();

                    //Notifications
                    //services.AddScoped<IEmailNotification, EmailNotification>();

                    //Reports
                    //services.AddScoped<ICategoryReport, CategoryReport>();

                    //Connection
                    services.AddSingleton<ISqlDataAccess, SqlDataAccess>();
                });
        }
    }
}