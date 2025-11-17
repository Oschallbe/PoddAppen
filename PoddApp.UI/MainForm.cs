using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using PoddApp.DAL;
using System;
using System.Windows.Forms;

namespace PoddApp.UI
{
    public partial class MainForm : Form
    {
        private readonly PodcastRepository _repo;

        public MainForm()
        {
            InitializeComponent();

            var config = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            _repo = new PodcastRepository(
                config["Mongo:ConnectionString"],
                config["Mongo:Database"]
            );
        }

        private async void btnAddPodcast_Click(object sender, EventArgs e)
        {
            await _repo.AddAsync(new PoddApp.Models.Podcast
            {
                Name = "Podd från UI",
                RssUrl = "https://example.com/feed.xml",
                Category = "Teknik"
            });

            MessageBox.Show("✅ Podcast sparades i MongoDB!");
        }


        private async void btnTestConnection_Click_1(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("🔹 Steg 1: Startar test av MongoDB-anslutning...");

                var config = new ConfigurationBuilder()
                    .SetBasePath(AppContext.BaseDirectory)
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                    .Build();

                MessageBox.Show("🔹 Steg 2: appsettings.json laddades.");

                var connectionString = config["Mongo:ConnectionString"];

                if (string.IsNullOrWhiteSpace(connectionString))
                {
                    MessageBox.Show("❌ Ingen MongoDB-connection-string hittades i appsettings.json!");
                    return;
                }

                MessageBox.Show($"🔹 Steg 3: Connection string =\n{connectionString}");

                var client = new MongoClient(connectionString);

                MessageBox.Show("🔹 Steg 4: MongoClient skapad. Hämtar databaser...");

                var dbList = await client.ListDatabaseNamesAsync();

                string message = "✅ Anslutning till MongoDB lyckades!\n\nDatabaser:\n";
                await foreach (var db in dbList.ToAsyncEnumerable())
                {
                    message += "- " + db + "\n";
                }

                MessageBox.Show(message, "MongoDB Test");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Misslyckades att ansluta till MongoDB:\n\n{ex}", "Fel");
            }
        }

    }
}
