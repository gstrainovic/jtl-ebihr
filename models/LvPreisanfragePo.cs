using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class LvPreisanfragePo
{
    public int KLieferantenBestellungPos { get; set; }

    public int KLieferantenBestellung { get; set; }

    public string? CLieferantenArtNr { get; set; }

    public string? CArtNr { get; set; }

    public int KArtikel { get; set; }

    public string? CName { get; set; }

    public string? CNameLief { get; set; }

    public decimal FUst { get; set; }

    public decimal FMenge { get; set; }

    public decimal FEknetto { get; set; }

    public decimal? FAverageEkNetto { get; set; }

    public string? CHinweis { get; set; }

    public string? CHan { get; set; }
}
