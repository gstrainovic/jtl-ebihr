using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TLagerbestandBackup
{
    public int KArtikel { get; set; }

    public decimal FLagerbestand { get; set; }

    public DateTime DErstellt { get; set; }

    public string? CVersion { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
