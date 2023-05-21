using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VBestellung
{
    public int KBestellung { get; set; }

    public int KBenutzer { get; set; }

    public int KKunde { get; set; }

    public string CBestellNr { get; set; } = null!;

    public int? KVersandart { get; set; }

    public string? CLieferadressePlz { get; set; }

    public string? CLieferadresseLand { get; set; }

    public string? CRechnungsadresseFirma { get; set; }

    public string? CRechnungsadresseVorname { get; set; }

    public string? CRechnungsadresseNachname { get; set; }

    public string? CRechnungsadresseStrasse { get; set; }

    public string? CRechnungsadressePlz { get; set; }

    public string? CRechnungsadresseOrt { get; set; }

    public int? KKundengruppe { get; set; }

    public string? CRueckhaltegrund { get; set; }
}
