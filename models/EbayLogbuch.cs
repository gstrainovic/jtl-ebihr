using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class EbayLogbuch
{
    public int KEbayLogbuch { get; set; }

    public int KEbayuser { get; set; }

    public string CBetreff { get; set; } = null!;

    public int NKategorie { get; set; }

    public int NTyp { get; set; }

    public string? CLog { get; set; }

    public DateTime DZeit { get; set; }
}
