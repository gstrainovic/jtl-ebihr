using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VRechnungPosition
{
    public int KRechnungPosition { get; set; }

    public int KRechnung { get; set; }

    public int? KAuftrag { get; set; }

    public int? KAuftragPosition { get; set; }

    public int? KArtikel { get; set; }

    public string? CArtNr { get; set; }

    public string? CName { get; set; }

    public string? CEinheit { get; set; }

    public decimal FAnzahl { get; set; }

    public decimal FMwSt { get; set; }

    public decimal FVkNetto { get; set; }

    public decimal FRabatt { get; set; }

    public byte NType { get; set; }

    public int? KKonfigVaterRechnungPos { get; set; }

    public int? KStuecklisteRechnungPos { get; set; }

    public decimal? FGewicht { get; set; }

    public decimal? FVersandgewicht { get; set; }

    public decimal? FEkNetto { get; set; }

    public int NSort { get; set; }

    public int? KSteuerschluessel { get; set; }

    public int? KSteuerklasse { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
