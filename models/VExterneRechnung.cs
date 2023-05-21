using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VExterneRechnung
{
    public int KExterneRechnung { get; set; }

    public string? CKundenNr { get; set; }

    public string? CName { get; set; }

    public string CExterneRechnungsnr { get; set; } = null!;

    public DateTime DBelegzeitpunktUtc { get; set; }

    public string CVerkaeuferUstId { get; set; } = null!;

    public string CVerkaeuferUstLandIso { get; set; } = null!;

    public string CKaeuferUstId { get; set; } = null!;

    public string CKaeuferUstLandIso { get; set; } = null!;

    public string? CSdIkontoNr { get; set; }

    public string? CWaehrungIso { get; set; }

    public decimal? FUmgerechneterGesamtUstBetrag { get; set; }

    public string? CRechnungsadresseFirma { get; set; }

    public string? CRechnungsadresseAnrede { get; set; }

    public string? CRechnungsadresseTitel { get; set; }

    public string? CRechnungsadresseVorname { get; set; }

    public string? CRechnungsadresseName { get; set; }

    public string? CRechnungsadresseStrasse { get; set; }

    public string? CRechnungsadresseOrt { get; set; }

    public string? CRechnungsadressePlz { get; set; }

    public string? CRechnungsadresseLand { get; set; }
}
