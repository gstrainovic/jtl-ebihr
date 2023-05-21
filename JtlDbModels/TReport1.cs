using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TReport1
{
    public int KReport { get; set; }

    public int KShop { get; set; }

    public string? CReportId { get; set; }

    public string CReportType { get; set; } = null!;

    public string? CResource { get; set; }

    public DateTime DCreated { get; set; }

    public DateTime? DRequested { get; set; }

    public DateTime? DStartDate { get; set; }

    public DateTime? DEndDate { get; set; }

    public byte[]? BDaten { get; set; }

    public byte NStatus { get; set; }
}
