using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TPicklisteVorlageAuftraege
{
    public int KPicklisteVorlage { get; set; }

    public int KAuftrag { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public byte? NIsTeillieferung { get; set; }
}
