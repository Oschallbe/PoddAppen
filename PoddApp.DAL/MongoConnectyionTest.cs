using MongoDB.Driver;
using System;
using System.Threading.Tasks;

namespace PoddApp.DAL
{
    public class MongoConnectionTest
    {
        public static async Task<string> TestAsync(string connectionString)
        {
            try
            {
                var client = new MongoClient(connectionString);
                var dbList = await client.ListDatabaseNamesAsync();

                string result = "✅ Anslutning till MongoDB lyckades!\n\nDatabaser:";
                await foreach (var db in dbList.ToAsyncEnumerable())
                {
                    result += $"\n - {db}";
                }

                return result;
            }
            catch (Exception ex)
            {
                return $"❌ Misslyckades att ansluta till MongoDB:\n{ex.Message}";
            }
        }
    }
}
