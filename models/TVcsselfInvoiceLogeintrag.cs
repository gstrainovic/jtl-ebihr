using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TVcsselfInvoiceLogeintrag
{
    public int KVcsselfInvoiceLogeintrag { get; set; }

    public int KAmazonabgleichLogsitzung { get; set; }

    public DateTime DZeitpunkt { get; set; }

    public byte NSchweregrad { get; set; }

    public string CMeldung { get; set; } = null!;

    public int KUser { get; set; }

    public byte NVorgang { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TAmazonabgleichLogsitzung KAmazonabgleichLogsitzungNavigation { get; set; } = null!;
}
