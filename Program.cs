using jtl_ebihr;

using var db = new EazyBusinessContext();


Console.WriteLine("Hello, World!");

var artikels = db.TArtikels.ToList();

foreach (var artikel  in artikels)
{
    Console.WriteLine($"{artikel.CArtNr}");
}