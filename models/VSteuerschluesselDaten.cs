using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VSteuerschluesselDaten
{
    public int? KWarengruppe { get; set; }

    public int? NPositionstyp { get; set; }

    public int? KVersandArt { get; set; }

    public int KSteuersatz { get; set; }

    public int? KSteuerzone { get; set; }

    public int? KSteuerklasse { get; set; }

    public int? KSteuerschluessel { get; set; }

    public int NSteuertyp { get; set; }
}
