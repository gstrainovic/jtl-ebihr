namespace jtl_ebihr;
using JtlDbModels;
using System.Net.Http.Headers;
using Client;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

public class Person
{
    public string name { get; set; } = "";
    public int age { get; set; }
    public Address? addresses { get; set; } = new Address();
}

public class Address
{
    public HomeAdress? home_adress { get; set; } = new HomeAdress();
}

public class HomeAdress
{
    public string street_street { get; set; } = "";
    public string city { get; set; } = "";
    public string state { get; set; } = "";
    public int zip { get; set; }
}

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;

    public Worker(ILogger<Worker> logger)
    {
        _logger = logger;
    }


    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        var yml = @"
        name: George Washington
        age: 89
        addresses:
          home_adress:
            street_street: 400 Mockingbird Lane
            city: Louaryland
            state: Hawidaho
            zip: 99970
        ";

        var deserializer = new DeserializerBuilder()
            .WithNamingConvention(UnderscoredNamingConvention.Instance)  // see height_in_inches in sample yml 
            .Build();

        //yml contains a string containing your YAML
        var p = deserializer.Deserialize<Person>(yml);
        System.Console.WriteLine($"{p.name} is {p.age} years old");

        // while (!stoppingToken.IsCancellationRequested)
        _logger.LogInformation("Worker running");

        Config config = new Config();
        // create the temp folder if it does not exist
        if (!Directory.Exists(config.jtl_bihr.temp_path))
        {
            Directory.CreateDirectory(config.jtl_bihr.temp_path);
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

        _logger.LogInformation("worker finished");

    }
}