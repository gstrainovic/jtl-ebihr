using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TBenutzerFeature
{
    public int KBenutzerFeature { get; set; }

    public int KBenutzer { get; set; }

    public string CFromVersion { get; set; } = null!;

    public string CToVersion { get; set; } = null!;

    public DateTimeOffset DSeen { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
