using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using PoddApp.BL;
using PoddApp.DAL;
using PoddApp.Models;
using System;
using System.Windows.Forms;


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
            //IPodcastRepo repo = new PodcastRepository(
            //    config["Mongo:ConnectionString"],
            //    config["Mongo:Database"]
            //);

            var client = new MongoClient(config["Mongo:ConnectionString"]);
            IPodcastRepo repo = new PodcastRepository(client, config["Mongo:Database"]);

            // WinForms standardinställningar
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();

            // Skapa service via interface
            IPoddService service = new PoddService(rssReader, repo);
            IValidation validation = new Validation(repo);


            // Starta appen 
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm(service, validation, repo));
        }
    }
}
