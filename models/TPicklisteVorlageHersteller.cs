using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TPicklisteVorlageHersteller
{
    public int KPicklisteVorlage { get; set; }

    public int KHersteller { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
