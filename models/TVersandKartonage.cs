using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TVersandKartonage
{
    public int KVersand { get; set; }

    public int KAuftragPosition { get; set; }

    public decimal FAnzahl { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
