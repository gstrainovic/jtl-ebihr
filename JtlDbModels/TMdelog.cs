using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TMdelog
{
    public int KMdelog { get; set; }

    public int? NLogId { get; set; }

    public DateTime? DDatum { get; set; }

    public int? KBenutzer { get; set; }

    public string? CLog { get; set; }

    public string? CView { get; set; }

    public int? NTime { get; set; }

    public int? NLogLevel { get; set; }

    public string? CSessionId { get; set; }

    public string? CServer { get; set; }
}
