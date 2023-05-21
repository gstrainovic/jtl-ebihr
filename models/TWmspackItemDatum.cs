using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TWmspackItemDatum
{
    public int KWmspackItemData { get; set; }

    public int KWmspackItem { get; set; }

    public string? CChargenNr { get; set; }

    public DateTime? DMhd { get; set; }

    public string? CSerNo { get; set; }

    public decimal FMenge { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
