using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TMedienDateiAttribut
{
    public int KMediendateiAttribut { get; set; }

    public int KMedienDatei { get; set; }

    public int KSprache { get; set; }

    public string CName { get; set; } = null!;

    public string CWert { get; set; } = null!;

    public byte[] BRowversion { get; set; } = null!;
}
