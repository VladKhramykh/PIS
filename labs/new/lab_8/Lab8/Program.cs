using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Lab8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}









/*
namespace Lab_8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
            .UseKestrel() // настраивает веб-сервер Kestrel
            .UseContentRoot(Directory.GetCurrentDirectory()) // настраивает корневой каталог приложения
            .UseIISIntegration() // обеспечивает интеграцию с IIS
            .UseStartup<Startup>() //устанавливает главный файл приложения
            .Build(); //создаёт хост
            host.Run();
        }
}
*/
