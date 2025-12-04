using System;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using PoddApp.BL;
using PoddApp.DAL;

namespace PoddApp.UI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            
            var http = new HttpClient();

            
            IRssReader rssReader = new RSSPodd(http);

           
            var config = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            
            IPodcastRepo repo = new PodcastRepository(
                config["Mongo:ConnectionString"],
                config["Mongo:Database"]
            );

            
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();

            
            IPoddService service = new PoddService(rssReader, repo);
            IValidation validation = new Validation(repo);


            
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm(service, validation));
        }
    }
}
