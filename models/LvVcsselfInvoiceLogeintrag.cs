using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class LvVcsselfInvoiceLogeintrag
{
    public int KVcsselfInvoiceLogeintrag { get; set; }

    public int KAmazonabgleichLogsitzung { get; set; }

    public DateTime DZeitpunkt { get; set; }

    public byte NSchweregrad { get; set; }

    public string CMeldung { get; set; } = null!;

    public int KUser { get; set; }

    public byte NVorgang { get; set; }
}
