using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TVerpackenSubset
{
    public int KVerpackenSubset { get; set; }

    public int KWarenLagerEingangSubset { get; set; }

    public string CSubsetNumber { get; set; } = null!;

    public decimal FFactor { get; set; }

    public int KAuftragsPos { get; set; }

    public int KPickliste { get; set; }

    public int KAuftrag { get; set; }

    public int NTyp { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
