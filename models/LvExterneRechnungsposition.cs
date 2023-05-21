using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class LvExterneRechnungsposition
{
    public int KExterneRechnungPosition { get; set; }

    public int? KExterneRechnungPositionVater { get; set; }

    public int KExterneRechnung { get; set; }

    public int? KAuftragPosition { get; set; }

    public int? KArtikel { get; set; }

    public string? CArtNr { get; set; }

    public decimal FAnzahl { get; set; }

    public decimal FSummeBrutto { get; set; }

    public decimal FSummeRabattBrutto { get; set; }

    public string CAuftragsnr { get; set; } = null!;

    public string CAuftragswaehrungIso { get; set; } = null!;

    public DateTime DAuftragszeitpunktUtc { get; set; }
}
