using Microsoft.Extensions.Configuration;
using System;

Program.Main();

internal partial class Program
{
    private static IConfigurationRoot _config;

    private static string _defaultFileName;
    private static string _defaultInPath;
    private static string _defaultOutPath;
    private static string _defaulFileFullPath;

    static void Main()
    {
        Startup();

        //Console.WriteLine($"Press enter to process '{_defaultFileName}'...");
        Console.ReadKey();
    }

    private static void Startup()
    {
        StartConfig();
    }

    private static void StartConfig()
    {
        // AppSettings / Config
        var builder = new ConfigurationBuilder()
           .AddJsonFile($"appsettings.json", true, true);

        _config = builder.Build();

        // Set values
        _defaultFileName = _config["DefaultFileName"];
        _defaultInPath = _config["DefaultInFolder"];
        _defaultOutPath = _config["DefaultOutFolder"];
        _defaulFileFullPath = _defaultInPath + _defaultFileName;
    }
}
