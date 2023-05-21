using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TBenutzerFirma
{
    public int KBenutzer { get; set; }

    public int KFirma { get; set; }

    public int KMandant { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
