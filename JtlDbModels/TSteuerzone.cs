using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TSteuerzone
{
    public int KSteuerzone { get; set; }

    public int KFirma { get; set; }

    public string? CName { get; set; }

    public string? CLandIso { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public byte NUstIdB2b { get; set; }

    public byte NUstIdB2c { get; set; }
}
