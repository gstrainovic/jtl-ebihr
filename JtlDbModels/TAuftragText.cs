using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TAuftragText
{
    public int KAuftrag { get; set; }

    public string? CAnmerkung { get; set; }

    public string? CDrucktext { get; set; }

    public string? CHinweis { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public string? CVorgangsstatus { get; set; }

    public virtual TAuftrag KAuftragNavigation { get; set; } = null!;
}
