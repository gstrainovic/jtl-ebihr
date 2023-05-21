using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TRmstatusBerechtigung
{
    public int KRmstatus { get; set; }

    public int KRechtBenutzerGruppe { get; set; }

    public byte NStatusSetzen { get; set; }

    public byte NStatusVerlassen { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
