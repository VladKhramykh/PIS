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
            .UseKestrel() // ����������� ���-������ Kestrel
            .UseContentRoot(Directory.GetCurrentDirectory()) // ����������� �������� ������� ����������
            .UseIISIntegration() // ������������ ���������� � IIS
            .UseStartup<Startup>() //������������� ������� ���� ����������
            .Build(); //������ ����
            host.Run();
        }
}
*/
