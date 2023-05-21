using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TSteuerzoneLand
{
    public int KSteuerzone { get; set; }

    public string CIso { get; set; } = null!;

    public string CKuerzelBundesland { get; set; } = null!;

    public byte[] BRowversion { get; set; } = null!;
}
