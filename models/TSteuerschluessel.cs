using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TSteuerschluessel
{
    public int KSteuerschluessel { get; set; }

    public string? CName { get; set; }

    public string? CSteuerkonto { get; set; }

    public string? CSkontokonto { get; set; }

    public string? CBonuskonto { get; set; }

    public string? CErloeskonto { get; set; }

    public string? CAusbuchungskonto { get; set; }

    public string? CAnzahlungskonto { get; set; }

    public byte? NAnzahlung { get; set; }

    public byte? NAutomatik { get; set; }

    public int? NSchluesselnummer { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual ICollection<TAuftragPosition> TAuftragPositions { get; set; } = new List<TAuftragPosition>();

    public virtual ICollection<TRechnungPosition> TRechnungPositions { get; set; } = new List<TRechnungPosition>();
}
