using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TAdressExportFelder
{
    public int? KAdressExportVorlage { get; set; }

    public int? NFeldNr { get; set; }

    public string? CPrefix { get; set; }

    public string? CWert { get; set; }

    public string? CSuffix { get; set; }

    public string? CStandardWert { get; set; }

    public string? CName { get; set; }

    public int? NMaxlen { get; set; }

    public string? CZusatzzeile { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
