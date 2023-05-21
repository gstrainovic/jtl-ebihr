using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TEbayAbgleichLogeintrag
{
    public int KEbayAbgleichLogeintrag { get; set; }

    public int KEbayAbgleichLogsitzung { get; set; }

    public DateTime DZeitpunkt { get; set; }

    public byte NSchweregrad { get; set; }

    public string CMeldung { get; set; } = null!;

    public int KEbayUser { get; set; }

    public int KSiteId { get; set; }

    public int KItemId { get; set; }

    public byte NVorgang { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TEbayAbgleichLogsitzung KEbayAbgleichLogsitzungNavigation { get; set; } = null!;
}
