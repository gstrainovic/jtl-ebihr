using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TDbErrorlog
{
    public int KDbErrorlog { get; set; }

    public DateTime DZeitstempel { get; set; }

    public string? CAppName { get; set; }

    public string? CHostName { get; set; }

    public string? CInformation { get; set; }

    public int? NErrorNumber { get; set; }

    public int? NErrorSeverity { get; set; }

    public int? NErrorLine { get; set; }

    public int? NErrorState { get; set; }

    public string? CErrorProcedure { get; set; }

    public string? CErrorMessage { get; set; }

    public string? CLockStatus { get; set; }

    public string? CDeadlockGraph { get; set; }
}
