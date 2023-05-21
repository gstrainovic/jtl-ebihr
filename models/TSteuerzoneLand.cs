using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TSteuerzoneLand
{
    public int KSteuerzone { get; set; }

    public string CIso { get; set; } = null!;

    public string CKuerzelBundesland { get; set; } = null!;

    public byte[] BRowversion { get; set; } = null!;
}
