using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TKundenGruppeAttribute
{
    public int KKundenGruppeAttribute { get; set; }

    public int KKundenGruppe { get; set; }

    public string? CName { get; set; }

    public string? CValue { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
