using Env;
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
        _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
        // while (!stoppingToken.IsCancellationRequested)
        // {
        //     await Task.Delay(1000, stoppingToken);
        // }
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
            SerializationType.JSON,
            CatalogType.ExtendedReferences,
            CatalogCompletion.Full
        );
        
        // get the downloadId
        var download = await catalogClient.GetGenerationStatusAsync(ticket.TicketId);

        // reqeust the download
        await catalogClient.GetGeneratedFileAsync(download.DownloadId);

        // db test
        using var db = new EazyBusinessContext();
        var artikels = db.TArtikels.ToList();
        foreach (var artikel in artikels)
        {
            Console.WriteLine($"{artikel.CArtNr}");
        }

    }
}