using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class PfAmazonFeederror
{
    public int? KUser { get; set; }

    public string? CSku { get; set; }

    public int? NErrorCode { get; set; }

    public string? CErrorType { get; set; }

    public string? CErrorMessage { get; set; }

    public string? CAbhilfe { get; set; }

    public DateTime? DErstellt { get; set; }

    public int? NPlattform { get; set; }

    public string? CFeedType { get; set; }
}
