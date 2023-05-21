using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TGutschriftLog
{
    public int KGutschriftLog { get; set; }

    public int KGutschrift { get; set; }

    public string? CGutschriftNr { get; set; }

    public byte? NGutschriftType { get; set; }

    public DateTime DErstelltUtc { get; set; }

    public byte NLogTyp { get; set; }

    public string CAppName { get; set; } = null!;

    public byte[]? BXml { get; set; }

    public byte[] BRowVersion { get; set; } = null!;

    public byte[]? BLastRowVersion { get; set; }
}
