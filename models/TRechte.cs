using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TRechte
{
    public int KRechte { get; set; }

    public int? KRecht { get; set; }

    public int? KRechtBenutzerGruppe { get; set; }

    public int? NAktiv { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
