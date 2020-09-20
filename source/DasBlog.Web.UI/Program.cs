using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace DasBlog.Web.UI
{
	public class Program
	{
		public static void Main(string[] args)
		{
			try
			{
				CreateWebHostBuilder(args).Build().Run();
			}
			catch(System.Exception ex)
			{
				System.Console.WriteLine(ex.ToString());
			}

			System.Console.ReadLine();
		}

		public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
			WebHost.CreateDefaultBuilder(args)
				.UseStartup<Startup>();
	}
}
