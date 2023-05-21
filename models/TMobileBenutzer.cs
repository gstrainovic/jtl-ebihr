using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TMobileBenutzer
{
    public int KMobileBenutzer { get; set; }

    public string CName { get; set; } = null!;

    public string CUniqueId { get; set; } = null!;

    public DateTime DLetzteAktion { get; set; }

    public string? CIpAddress { get; set; }

    public int KBenutzer { get; set; }

    public int KWarenlager { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
