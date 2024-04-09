using Microsoft.Extensions.DependencyInjection;

namespace DbDI
{
    internal static class Program
    {
        [STAThread]

        //static void Main()
        //{
        //    ApplicationConfiguration.Initialize();
        //    Application.Run(new Form1());
        //}
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);

            using (var serviceProvider = services.BuildServiceProvider())
            {
                var Form1 = serviceProvider.GetRequiredService<Form1>();
                Application.Run(Form1);
            }
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IDbCon>(provider => new DbConService(Data.Chain1));
            services.AddSingleton<ILogger, LoggerService>();
            services.AddTransient<Form1>();
        }


    }
}