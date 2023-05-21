using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TAmazonbestellpositionVcszuordnung
{
    public long KMessageId { get; set; }

    public int KAmazonBestellungPos { get; set; }

    public byte NTyp { get; set; }

    public int? KRechnungPosition { get; set; }
}
