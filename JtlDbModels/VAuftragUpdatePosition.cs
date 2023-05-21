using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VAuftragUpdatePosition
{
    public int KAuftrag { get; set; }

    public int? KArtikel { get; set; }

    public int? KVersandklasse { get; set; }

    public string? CName { get; set; }

    public string? CLieferstatus { get; set; }

    public string? CArtNr { get; set; }

    public string? CEinheit { get; set; }

    public decimal? FPreisEinzelNetto { get; set; }

    public decimal? FPreis { get; set; }

    public decimal FMwSt { get; set; }

    public decimal NAnzahl { get; set; }

    public byte NPosTyp { get; set; }

    public string? CHinweis { get; set; }

    public int KKonfigitem { get; set; }

    public string? CUnique { get; set; }

    public int KBestellpos { get; set; }
}
