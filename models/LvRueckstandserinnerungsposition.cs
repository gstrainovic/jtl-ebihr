using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class LvRueckstandserinnerungsposition
{
    public int KLieferantenBestellungErinnerung { get; set; }

    public string? CArtNr { get; set; }

    public string? CLieferantenArtNr { get; set; }

    public string? CName { get; set; }

    public decimal FUst { get; set; }

    public decimal FAnzahl { get; set; }

    public decimal FEknetto { get; set; }

    public decimal? FEknettoGesamt { get; set; }

    public string? CHinweis { get; set; }
}
