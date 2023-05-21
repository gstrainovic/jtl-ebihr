using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TRechnungLog
{
    public int KRechnungLog { get; set; }

    public int KRechnung { get; set; }

    public string? CRechnungsNr { get; set; }

    public DateTime DErstelltUtc { get; set; }

    public byte NLogTyp { get; set; }

    public string CAppName { get; set; } = null!;

    public byte[]? BXml { get; set; }

    public byte[] BRowVersion { get; set; } = null!;

    public byte[]? BLastRowVersion { get; set; }
}
