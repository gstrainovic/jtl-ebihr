using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class LvVcsInvoiceDuplicate
{
    public int KAuftrag { get; set; }

    public string CAuftragsNr { get; set; } = null!;

    public string CExterneAuftragsNr { get; set; } = null!;

    public DateTime DAuftragsdatum { get; set; }

    public decimal FAuftragsbetrag { get; set; }

    public int? KRechnung { get; set; }

    public string? CRechnungsNr { get; set; }

    public decimal? FRechnungsbetrag { get; set; }

    public DateTime? DRechnungsdatum { get; set; }

    public string? CExterneRechnungsNr { get; set; }

    public DateTime? DExternErstelldatum { get; set; }

    public decimal? FExternerRechnungsbetrag { get; set; }
}
