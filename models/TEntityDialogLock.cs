using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TEntityDialogLock
{
    public int KEntityDialogLock { get; set; }

    public int KEntity { get; set; }

    public string CDialogName { get; set; } = null!;

    public int KBenutzer { get; set; }

    public int NProcessId { get; set; }

    public string CHostName { get; set; } = null!;

    public DateTimeOffset DExpire { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public int? KEntityDialogLockReleased { get; set; }

    public string? CInfo { get; set; }
}
