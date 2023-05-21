using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VLagerartikel
{
    public int KLagerartikel { get; set; }

    public int? KBestellPos { get; set; }

    public int? KLieferscheinPos { get; set; }

    public int KLieferschein { get; set; }

    public int? KSessionId { get; set; }

    public int KPicklistePos { get; set; }

    public int? KWarenlager { get; set; }

    public string? CSeriennr { get; set; }

    public string? CBeschreibung1 { get; set; }

    public string? CBeschreibung2 { get; set; }
}
