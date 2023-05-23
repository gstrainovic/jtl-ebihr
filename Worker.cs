namespace jtl_ebihr;
using JtlDbModels;
using System.Net.Http.Headers;
using Client;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;

    public Worker(ILogger<Worker> logger)
    {
        _logger = logger;
    }


    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {

        while (!stoppingToken.IsCancellationRequested)
        {
            _logger.LogInformation("Worker running");


            // create the temp folder if it does not exist
            if (!Directory.Exists(Config.tempPath))
            {
                Directory.CreateDirectory(Config.tempPath);
            }

            var httpClient = new HttpClient();

            var tokenClient = new Client.AuthenticationClient(Config.url, httpClient);
            var token = await tokenClient.PostTokenAsync(Secret.BihrUserName, Secret.BihrPassWord);

            // add the token to the http client
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.Access_token);

            // get the catalog client
            var catalogClient = new Client.CatalogClient(Config.url, httpClient);

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

            _logger.LogInformation("Waiting 24h for next run");
            await Task.Delay(1000 * 60 * 60 * 24, stoppingToken);
        }

    }
}