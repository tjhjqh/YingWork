using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using YingWork.Data.Model.Config;

namespace YingWork.UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            var services = new ServiceCollection();
            ConfigureServices(services);
            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                MainForm form = serviceProvider.GetService<MainForm>();
                Application.Run(form);
            }
        }
        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddTransient<MainForm>();

            var config = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json").Build();


            var section = config.GetSection(nameof(AppConfig));
            var appConfig = section.Get<AppConfig>();

            services.AddSingleton(appConfig);
        }
    }
}
