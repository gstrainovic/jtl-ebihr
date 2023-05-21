using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TTexteMitValue
{
    public int? KSessionId { get; set; }

    public int? KBenutzer { get; set; }

    public int? NTextId { get; set; }

    public DateTime? DZeitstempel { get; set; }

    public string? CValue1 { get; set; }

    public string? CValue2 { get; set; }

    public string? CValue3 { get; set; }

    public string? CValue4 { get; set; }

    public string? CValue5 { get; set; }

    public int? NValue1 { get; set; }

    public int? NValue2 { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
