using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TZahlungsabgleichAmaPayReportRequest
{
    public int KZahlungsabgleichAmaPayReportRequests { get; set; }

    public int KZahlungsabgleichModul { get; set; }

    public string? CRequestId { get; set; }
}
