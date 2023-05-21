using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TPicklisteVorlageSichtbarkeitVersandBox
{
    public int KPicklisteVorlage { get; set; }

    public int KVersandBox { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
