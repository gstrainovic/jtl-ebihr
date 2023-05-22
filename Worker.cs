namespace jtl_ebihr;
using JtlDbModels;
using System.Net.Http.Headers;
using Client;

public class Worker : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        Logger.Info("Worker started"); 
        var httpClient = new HttpClient();

        var tokenClient =  new Client.AuthenticationClient(env.url, httpClient);
        var token = await tokenClient.PostTokenAsync(env.userName, env.passWord);

        // add the token to the http client
        httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.Access_token);

        // get the catalog client
        var catalogClient = new Client.CatalogClient(env.url, httpClient);

        // get the ticketId from the catalog
        var ticket = await catalogClient.PostRequestAsync(
            CompressionType.ZIP,
            SerializationType.CSV,
            CatalogType.ExtendedReferences,
            CatalogCompletion.Full
        );
        
        // log the ticketId for download the catalog
        Logger.Info($"TicketId: {ticket.TicketId}");

        // repeat the get downloadId until the download is ready
        var download = await catalogClient.GetGenerationStatusAsync(ticket.TicketId);
        while (download.RequestStatus != "DONE")
        {   
            Logger.Info($"Status: {download.RequestStatus}, DownloadId: {download.DownloadId}");
            Logger.Info("Waiting 1s for download to be ready");
            await Task.Delay(1000);
            download = await catalogClient.GetGenerationStatusAsync(ticket.TicketId);
            Logger.Info($"Status: {download.RequestStatus}, DownloadId: {download.DownloadId}");
        }
        // log the DownloadId for download the catalog
        Logger.Info($"DownloadId: {download.DownloadId}");

        // request the download
        await catalogClient.GetGeneratedFileAsync(download.DownloadId);

        // db test
        using var db = new EazyBusinessContext();
        var artikels = db.TArtikels.ToList();
        foreach (var artikel in artikels)
        {
            Logger.Info($"{artikel.CArtNr}");
        }

    }
}