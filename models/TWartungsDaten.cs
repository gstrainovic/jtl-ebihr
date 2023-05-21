using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TWartungsDaten
{
    public int KWartungsDaten { get; set; }

    public string CKatalog { get; set; } = null!;

    public string CInhalt { get; set; } = null!;

    public DateTime DWartungsDatenTag { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
