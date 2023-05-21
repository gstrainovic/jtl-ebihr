using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VLock
{
    public int Spid { get; set; }

    public string? DatabaseName { get; set; }

    public string? LockedObjectName { get; set; }

    public int? LockedObjectId { get; set; }

    public string LockedResource { get; set; } = null!;

    public string LockType { get; set; } = null!;

    public string? SqlStatementText { get; set; }

    public string? LoginName { get; set; }

    public string? HostName { get; set; }

    public string? ClientName { get; set; }

    public bool? IsUserTransaction { get; set; }

    public string? TransactionName { get; set; }
}
