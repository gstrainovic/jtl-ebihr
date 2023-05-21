using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class LvPakete
{
    public int KKunde { get; set; }

    public int KBestellung { get; set; }

    public int KLieferschein { get; set; }

    public int KInternePaketnummer { get; set; }

    public string? CTrackingId { get; set; }

    public string? CSendungsreferenz { get; set; }

    public DateTime? DVerpackt { get; set; }

    public DateTime? DVersendet { get; set; }

    public string? CHinweis { get; set; }

    public string? CFulfillmentCenter { get; set; }

    public DateTime? DVoraussichtlichesLieferdatum { get; set; }

    public string CVersandartName { get; set; } = null!;

    public decimal FGewicht { get; set; }

    public byte? NTrackingStatus { get; set; }

    public byte? NVersandStatus { get; set; }

    public string? CLieferscheinNr { get; set; }

    public string CBestellNr { get; set; } = null!;
}
