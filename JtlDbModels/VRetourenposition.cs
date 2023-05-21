using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VRetourenposition
{
    public int KBestellPos { get; set; }

    public string? CArtNr { get; set; }

    public decimal NAnzahl { get; set; }

    public int NMenge { get; set; }

    public int? NMaxRetoureMenge { get; set; }

    public int NRetourMenge { get; set; }

    public int NOffeneMenge { get; set; }

    public decimal? FAmountPerItem { get; set; }

    public string? COrderId { get; set; }

    public string? CSellerSku { get; set; }

    public decimal NMengeGutgeschrieben { get; set; }

    public int KBestellung { get; set; }

    public int KArtikel { get; set; }

    public decimal FMwSt { get; set; }

    public int? NPlatform { get; set; }
}
