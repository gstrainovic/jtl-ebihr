using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VRechnung
{
    public int? TBestellungKBestellung { get; set; }

    public int KRechnung { get; set; }

    public int? TBenutzerKBenutzer { get; set; }

    public int? TKundeKKunde { get; set; }

    public string CRechnungsNr { get; set; } = null!;

    public string CBezahlt { get; set; } = null!;

    public DateTime DErstellt { get; set; }

    public int? NZahlungsziel { get; set; }

    public string CStatus { get; set; } = null!;

    public string? CErloeskonto { get; set; }

    public int KFirma { get; set; }

    public int NInkassoStatus { get; set; }

    public DateTime? DEmailversandt { get; set; }

    public DateTime? DDruckdatum { get; set; }

    public bool NMahnstop { get; set; }
}
