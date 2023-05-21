using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class EbayZahlungOut
{
    public int? KEbayCheckout { get; set; }

    public string? DDatum { get; set; }

    public decimal FBetrag { get; set; }
}
