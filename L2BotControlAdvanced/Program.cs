using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using L2BotControlAdvanced.Services;
using L2BotControlAdvanced.Views;
using Microsoft.Extensions.DependencyInjection;

namespace L2BotControlAdvanced
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

            // Remember: non-primitive objects are passed by reference
            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var form1 = serviceProvider.GetRequiredService<Form1>();
                Application.Run(form1);
            }
        }

        public static void ConfigureServices(ServiceCollection services)
        {
            // first, register application services:
            services.AddSingleton<IConfigService, ConfigService>()
                    .AddSingleton<ICameraService, CameraService>()
                    .AddSingleton<IRobotControllerService, LoCoMoCoControllerService>()
                    .AddTransient<IImageManipulationService, ImageManipulationService>();

            // now, register the windows forms so services can be injected into them:
            services.AddScoped<Form1>()
                    .AddScoped<BinaryThresholdConfigForm>()
                    .AddScoped<HSVThresholdConfigForm>();
        }
    }
}
