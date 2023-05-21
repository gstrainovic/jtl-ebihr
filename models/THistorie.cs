using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class THistorie
{
    public int KKunde { get; set; }

    public int? KAuftrag { get; set; }

    public int KVorgang { get; set; }

    public int? KKey { get; set; }

    public string? CValue1 { get; set; }

    public string? CValue2 { get; set; }

    public string? CValue3 { get; set; }

    public DateTime DErstellt { get; set; }

    public int? KBenutzer { get; set; }

    public decimal? FValue1 { get; set; }

    public decimal? FValue2 { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public int KHistorie { get; set; }
}
