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
            // Skapa HttpClient
            var http = new HttpClient();

            // Skapa RSS-läsaren via interfacet
            IRssReader rssReader = new RSSPodd(http);

            // Ladda appsettings.json
            var config = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            // Skapa Repository via interfacet
            IPodcastRepo repo = new PodcastRepository(
                config["Mongo:ConnectionString"],
                config["Mongo:Database"]
            );

            // WinForms standardinställningar
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();

            // Skapa service via interface
            IPoddService service = new PoddService(rssReader, repo);

            // Starta appen och skicka in service (Interface!!)
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm(service));
        }
    }
}
