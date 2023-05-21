using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TPicklisteVorlageSichtbarkeitPickwagen
{
    public int KPicklisteVorlage { get; set; }

    public int KPickwagen { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
