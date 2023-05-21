using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TDatevLog
{
    public int KDatevLog { get; set; }

    public int KBeleg { get; set; }

    public int KFirma { get; set; }

    public string? CFehlerMessage { get; set; }

    public int? NDatevUebertragungsStatus { get; set; }

    public DateTime? DUebertragungsDatum { get; set; }

    public int NDatevBelegTyp { get; set; }

    public string? CLogLocation { get; set; }

    public string? CJsonData { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
