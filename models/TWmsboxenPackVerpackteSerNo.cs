using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TWmsboxenPackVerpackteSerNo
{
    public int KWmsboxenPackVerpackteSerNos { get; set; }

    public int KBestellung { get; set; }

    public int KBestellPos { get; set; }

    public int KArtikel { get; set; }

    public string CSerNo { get; set; } = null!;

    public byte[] BRowversion { get; set; } = null!;
}
