
using Env;
using BihrClient;
using JtlDbModels;

public class Programm
{
    public static void Main()
    {
        Console.WriteLine("Hello, World!");

        string userName = env.userName;
        string password = env.passWord;
        Console.WriteLine(userName);
        Console.WriteLine(password);

        // authentication provider
        Uri url = new Uri(env.url);
        // var httpClient = new HttpClient(BaseAddress = url);
        var httpClient = new HttpClient();
        httpClient.BaseAddress = url;

        var client = new BihrClientClient(httpClient);
        var cancellationToken = new CancellationToken();
        var token = client.PostToken(env.passWord, env.userName, cancellationToken);

        // print the token
        Console.WriteLine(token);



        using var db = new EazyBusinessContext();

        var artikels = db.TArtikels.ToList();

        foreach (var artikel in artikels)
        {
            Console.WriteLine($"{artikel.CArtNr}");
        }

    }
}