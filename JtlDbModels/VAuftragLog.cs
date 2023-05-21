using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VAuftragLog
{
    public int KAuftragLog { get; set; }

    public DateTime DErstelltUtc { get; set; }

    public byte NLogTyp { get; set; }

    public string CLogTyp { get; set; } = null!;

    public int KAuftrag { get; set; }

    public string? CAuftragsNr { get; set; }

    public byte? NAuftragType { get; set; }

    public string CAuftragType { get; set; } = null!;

    public string CAppName { get; set; } = null!;

    public string? CXml { get; set; }

    public byte[]? BXml { get; set; }

    public byte[] BRowVersion { get; set; } = null!;

    public byte[]? BLastRowVersion { get; set; }

    public long? NLogAbstand { get; set; }

    public string? CPrüfStatus { get; set; }
}
