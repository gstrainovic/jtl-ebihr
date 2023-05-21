using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TWarenLagerEingangHistorie
{
    public int? KWarenLagerEingang { get; set; }

    public int? KWarenLagerPlatzStart { get; set; }

    public int? KWarenLagerPlatzZiel { get; set; }

    public DateTime? DZeitstempel { get; set; }

    public int? KBenutzer { get; set; }

    public string? CKommentar { get; set; }

    public int? KBuchungsArt { get; set; }

    public int? KSessionId { get; set; }

    public decimal FAnzahl { get; set; }

    public int? KLhmstart { get; set; }

    public int? KLhmziel { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public int KWarenLagerEingangHistorie { get; set; }

    public string? CSubsetNumber { get; set; }

    public string? CDimensionen { get; set; }
}
