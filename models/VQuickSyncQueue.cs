using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VQuickSyncQueue
{
    public int KArtikel { get; set; }

    public int KShop { get; set; }

    public string? CInet { get; set; }

    public string? CDelInet { get; set; }

    public int NAktion { get; set; }

    public byte? NInBearbeitung { get; set; }
}
