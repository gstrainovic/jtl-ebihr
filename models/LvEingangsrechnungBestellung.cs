using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class LvEingangsrechnungBestellung
{
    public int KLieferantenBestellung { get; set; }

    public string? CEigeneBestellnummer { get; set; }

    public string? CFremdbelegnummer { get; set; }

    public int? KEingangsrechnung { get; set; }
}
