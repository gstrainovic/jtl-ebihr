using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TAuftragPositionLog
{
    public int KAuftragPositionLog { get; set; }

    public int? KBenutzerLog { get; set; }

    public DateTime DLog { get; set; }

    public int NActionLog { get; set; }

    public int KAuftragPosition { get; set; }

    public int? KArtikel { get; set; }

    public int KAuftrag { get; set; }

    public string? CArtNr { get; set; }

    public bool NReserviert { get; set; }

    public string? CName { get; set; }

    public string? CHinweis { get; set; }

    public decimal FAnzahl { get; set; }

    public decimal FEkNetto { get; set; }

    public decimal FVkNetto { get; set; }

    public decimal FRabatt { get; set; }

    public decimal FMwSt { get; set; }

    public int NSort { get; set; }

    public string? CNameStandard { get; set; }

    public int? KSteuerklasse { get; set; }

    public byte NType { get; set; }

    public string? CEinheit { get; set; }

    public bool NHatUpload { get; set; }

    public int? KKonfigVater { get; set; }

    public int? KKonfigItem { get; set; }

    public int? KAmazonBestellungPos { get; set; }

    public int? KAuftragStueckliste { get; set; }

    public int? KEbayTransaction { get; set; }

    public decimal FFaktor { get; set; }

    public int? KSteuerschluessel { get; set; }

    public decimal? FWertNettoGesamtFixiert { get; set; }

    public decimal? FWertBruttoGesamtFixiert { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public string? CFnsku { get; set; }
}
