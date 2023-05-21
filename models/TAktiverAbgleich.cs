using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TAktiverAbgleich
{
    public int KAktiverEmailAbgleich { get; set; }

    public string CHostname { get; set; } = null!;

    public DateTime DLock { get; set; }

    public int NProcessId { get; set; }
}
