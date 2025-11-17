using System;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using PoddApp.DAL;

namespace PoddApp.UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();


            // Standard WinForms-setup
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());


        }
    }
}
