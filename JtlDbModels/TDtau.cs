using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TDtau
{
    public string? CName { get; set; }

    public string? CZeile1 { get; set; }

    public string? CZeile2 { get; set; }

    public byte? NZahlung { get; set; }

    public string? CKontoInhaber { get; set; }

    public string? CBlz { get; set; }

    public string? CKontoNr { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
