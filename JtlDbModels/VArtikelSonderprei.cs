using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VArtikelSonderprei
{
    public int KArtikelSonderpreis { get; set; }

    public int KArtikel { get; set; }

    public string CAktiv { get; set; } = null!;

    public DateTime? DStart { get; set; }

    public int? NAnzahl { get; set; }

    public DateTime? DEnde { get; set; }

    public byte? NIstAnzahl { get; set; }

    public byte? NIstDatum { get; set; }

    public int KKundenGruppe { get; set; }

    public decimal FNettoPreis { get; set; }

    public int KShop { get; set; }
}
