using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class Tbenutzerrechte
{
    public int? KBenutzerRechte { get; set; }

    public int? KBenutzer { get; set; }

    public int? NRechte { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
