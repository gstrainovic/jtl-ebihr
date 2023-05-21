using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TRechnungPosition
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

    public decimal? FWertNettoGesamtFixiert { get; set; }

    public decimal? FWertBruttoGesamtFixiert { get; set; }

    public virtual TAuftragPosition? KAuftragPositionNavigation { get; set; }

    public virtual TRechnung1 KRechnungNavigation { get; set; } = null!;

    public virtual TSteuerklasse? KSteuerklasseNavigation { get; set; }

    public virtual TSteuerschluessel? KSteuerschluesselNavigation { get; set; }

    public virtual ICollection<TRechnungLieferscheinPosition> TRechnungLieferscheinPositions { get; set; } = new List<TRechnungLieferscheinPosition>();

    public virtual TRechnungPositionEckdaten? TRechnungPositionEckdaten { get; set; }

    public virtual ICollection<TRechnungPositionFile> TRechnungPositionFiles { get; set; } = new List<TRechnungPositionFile>();

    public virtual TRechnungPositionTeilmengen? TRechnungPositionTeilmengen { get; set; }

    public virtual ICollection<TRechnungPositionTeilmengenKonfiguration> TRechnungPositionTeilmengenKonfigurations { get; set; } = new List<TRechnungPositionTeilmengenKonfiguration>();

    public virtual TRechnungPositionText? TRechnungPositionText { get; set; }
}
