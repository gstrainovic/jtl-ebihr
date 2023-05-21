using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TVoucherEinloesungen
{
    public int KVoucherEinloesungen { get; set; }

    public int KAuftrag { get; set; }

    public int? KAuftragPosition { get; set; }

    public int? KZahlung { get; set; }

    public string CVoucherId { get; set; } = null!;

    public string CUsageId { get; set; } = null!;

    public decimal FAmount { get; set; }

    public bool NStorno { get; set; }

    public int? KZahlungGegenbuchung { get; set; }

    public DateTime DEingeloest { get; set; }

    public int? KZahlungsart { get; set; }

    public virtual TAuftrag KAuftragNavigation { get; set; } = null!;

    public virtual TAuftragPosition? KAuftragPositionNavigation { get; set; }

    public virtual TZahlung? KZahlungGegenbuchungNavigation { get; set; }

    public virtual TZahlung? KZahlungNavigation { get; set; }

    public virtual TZahlungsart? KZahlungsartNavigation { get; set; }
}
