using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TTrackingLog
{
    public int KTrackingLog { get; set; }

    public DateTime DDateTime { get; set; }

    public string CMessage { get; set; } = null!;

    public string? CStackTrace { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
