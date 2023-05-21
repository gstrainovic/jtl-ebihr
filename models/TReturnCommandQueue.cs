using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TReturnCommandQueue
{
    public int KReturnCommandQueue { get; set; }

    public DateTimeOffset DModificationDate { get; set; }

    public DateTimeOffset DCreatedAt { get; set; }

    public DateTimeOffset? DProcessedAt { get; set; }

    public string? CSessionId { get; set; }

    public string? CRequestId { get; set; }

    public byte NType { get; set; }

    public byte NState { get; set; }

    public byte NRole { get; set; }

    public byte NTarget { get; set; }

    public byte NEvent { get; set; }

    public string CData { get; set; } = null!;

    public string? CErrorMessage { get; set; }

    public int NPriority { get; set; }

    public string CDataType { get; set; } = null!;

    public int KRmRetoure { get; set; }

    public string CReturnId { get; set; } = null!;
}
