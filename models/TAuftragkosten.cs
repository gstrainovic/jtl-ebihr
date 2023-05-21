using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TAuftragkosten
{
    public int KAuftragkosten { get; set; }

    public int KAuftrag { get; set; }

    public int? KAuftragPosition { get; set; }

    public string? CSku { get; set; }

    public byte NKostentyp { get; set; }

    public decimal FSumme { get; set; }

    public string CBeschreibung { get; set; } = null!;

    public DateTime DBerechnungsdatumUtc { get; set; }

    public DateTime DErstelltUtc { get; set; }

    public long? KSettlementPos { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TAuftragPosition? KAuftragPositionNavigation { get; set; }

    public virtual PfAmazonSettlementpo? KSettlementPosNavigation { get; set; }
}
