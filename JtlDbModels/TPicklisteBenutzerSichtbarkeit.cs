using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TPicklisteBenutzerSichtbarkeit
{
    public int KPicklisteVorlage { get; set; }

    public int KBenutzer { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
