using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class LvExternerBelegPositionen
{
    public int KExternerBelegPosition { get; set; }

    public int? KExternerBelegPositionVater { get; set; }

    public int KExternerBeleg { get; set; }

    public int? KAuftragPosition { get; set; }

    public int? KArtikel { get; set; }

    public string CArtNr { get; set; } = null!;

    public decimal FAnzahl { get; set; }

    public decimal? FVkBrutto { get; set; }

    public decimal? FVkNetto { get; set; }

    public string? CExterneAuftragsnummer { get; set; }

    public DateTime? DExternesAuftragsdatumUtc { get; set; }
}
