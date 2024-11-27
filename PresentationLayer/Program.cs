using BusinessLayer.Services;
using DataLayer.DbConnection;
using DataLayer.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PresentationLayer.Forms;
using BusinessLayer.Services;
using DataLayer.Repositories;
using DataLayer.DbConnection;
using PresentationLayer.LoginF;
using QuestPDF.Infrastructure;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Configuration;
using PresentationLayer.ManagerForms;
using PresentationLayer.Forms.Player;


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

            Application.Run(ServiceProvider.GetRequiredService<PlayerDashboardForm>());
        }

        public static IServiceProvider ServiceProvider { get; private set; }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()

                .ConfigureAppConfiguration((context, config) => {
                    config.AddJsonFile(
                        "appsettings.json",
                        optional: false,
                        reloadOnChange: true
                     );
                })
                .ConfigureServices((context, services) => {

                    //Forms
                    services.AddTransient<dashboardAdmin>();
                    services.AddTransient<LoginForms>();
                    services.AddTransient<ManagerForm>();
                    services.AddTransient<PlayerDashboardForm>();

                    //Repositories
                    services.AddScoped<IMatchRepository, MatchRepository>();
                    services.AddScoped<ITeamsRepository, TeamsRepository>();
                    services.AddScoped<IPlayerRepository, PlayerRepository>();

                    //services.AddScoped<IEmailQueueRepository, EmailQueueRepository>();
                    services.AddScoped<IUserRepository, UserRepository>();
                    //Services


                    services.AddScoped<IMatchService, MatchService>();
                    services.AddScoped<ITeamService, TeamService>();
                    services.AddScoped<IUserService, UserService>();
                    services.AddScoped<IPlayerService, PlayerService>();

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