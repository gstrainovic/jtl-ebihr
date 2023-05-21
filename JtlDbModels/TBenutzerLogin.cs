using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TBenutzerLogin
{
    public int KBenutzerLogin { get; set; }

    public int KBenutzer { get; set; }

    public Guid UProvider { get; set; }

    public string CKey { get; set; } = null!;

    public string CToken { get; set; } = null!;

    public byte[] BRowversion { get; set; } = null!;
}
