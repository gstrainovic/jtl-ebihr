using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TRechnungText
{
    public int KRechnung { get; set; }

    public string? CRechnungstext { get; set; }

    public string? CAnmerkung { get; set; }

    public string? CHinweis { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TRechnung1 KRechnungNavigation { get; set; } = null!;
}
