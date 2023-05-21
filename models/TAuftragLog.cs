using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TAuftragLog
{
    public int KAuftragLog { get; set; }

    public int KAuftrag { get; set; }

    public string? CAuftragsNr { get; set; }

    public byte? NAuftragType { get; set; }

    public DateTime DErstelltUtc { get; set; }

    public byte NLogTyp { get; set; }

    public string CAppName { get; set; } = null!;

    public byte[]? BXml { get; set; }

    public byte[] BRowVersion { get; set; } = null!;

    public byte[]? BLastRowVersion { get; set; }
}
