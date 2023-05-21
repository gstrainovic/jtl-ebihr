using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VLieferscheinPositionInfo
{
    public int KLieferscheinPos { get; set; }

    public string? CSeriennr { get; set; }

    public DateTime? DMhd { get; set; }

    public string? CChargenNr { get; set; }
}
