using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TRechtBenutzerGruppenZuordnung
{
    public int KRechtBenutzerGruppe { get; set; }

    public int KBenutzer { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
