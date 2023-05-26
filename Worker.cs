namespace jtl_ebihr;
using JtlDbModels;
using System.Net.Http.Headers;
using Client;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;


public class Worker : BackgroundService
{
    private readonly IHostApplicationLifetime _hostApplicationLifetime;
    private readonly ILogger<Worker> _logger;

    public Worker(
        IHostApplicationLifetime hostApplicationLifetime, ILogger<Worker> logger) =>
        (_hostApplicationLifetime, _logger) = (hostApplicationLifetime, logger);


    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {

        // while (!stoppingToken.IsCancellationRequested)
        _logger.LogInformation("Worker running");

        Config config = new Config();
        // create the temp folder if it does not exist
        if (!Directory.Exists(Config.temp_path))
        {
            Directory.CreateDirectory(Config.temp_path);
        }

        var httpClient = new HttpClient();

        var tokenClient = new Client.AuthenticationClient(config.bihr.url, httpClient);
        var token = await tokenClient.PostTokenAsync(config.bihr.user_name, config.bihr.password);

        // add the token to the http client
        httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.Access_token);

        // get the catalog client
        var catalogClient = new Client.CatalogClient(config.bihr.url, httpClient);

        // get the ticketId from the catalog
        // var ticket = await catalogClient.PostRequestAsync(
        //     CompressionType.ZIP,
        //     SerializationType.CSV,
        //     CatalogType.ExtendedReferences,
        //     CatalogCompletion.Full
        // );

        // throw new NotImplementedException();
        // todo add also the other catalogs
        await catalogClient.PostEssentialHardPartRequestAsync();
        await catalogClient.PostEssentialRiderGearRequestAsync();

        // // log the ticketId for download the catalog
        // _logger.LogInformation($"TicketId: {ticket.TicketId}");

        // // repeat the get downloadId until the download is ready
        // var download = await catalogClient.GetGenerationStatusAsync(ticket.TicketId);
        // while (download.RequestStatus != "DONE")
        // {
        //     _logger.LogInformation($"Status: {download.RequestStatus}, DownloadId: {download.DownloadId}");
        //     _logger.LogInformation("Waiting 1s for download to be ready");
        //     await Task.Delay(1000);
        //     download = await catalogClient.GetGenerationStatusAsync(ticket.TicketId);
        //     _logger.LogInformation($"Status: {download.RequestStatus}, DownloadId: {download.DownloadId}");
        // }
        // // log the DownloadId for download the catalog
        // _logger.LogInformation($"DownloadId: {download.DownloadId}");

        // // request the download and start the processing
        // await catalogClient.GetGeneratedFileAsync(download.DownloadId);

        _logger.LogInformation("worker finished!");

        // wait 5 seconds before stopping the application
        await Task.Delay(5000);
         _hostApplicationLifetime.StopApplication();
         
        return;
    }
}