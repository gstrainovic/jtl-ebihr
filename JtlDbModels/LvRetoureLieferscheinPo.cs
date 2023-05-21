using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class LvRetoureLieferscheinPo
{
    public int KLieferscheinPos { get; set; }

    public decimal FAnzahl { get; set; }

    public int KAuftragPosition { get; set; }

    public int KAuftrag { get; set; }

    public string? CArtNr { get; set; }

    public byte NType { get; set; }

    public string? CName { get; set; }

    public int? KAuftragStueckliste { get; set; }

    public decimal FVkNetto { get; set; }

    public decimal FMwSt { get; set; }

    public decimal FRabatt { get; set; }

    public int? KArtikel { get; set; }

    public string? CTeilbar { get; set; }

    public int? KVaterArtikel { get; set; }

    public string? ArtikelName { get; set; }

    public string? CLieferscheinNr { get; set; }

    public DateTime? DPaketVersendet { get; set; }

    public decimal? AnzahlRetourniert { get; set; }

    public string? CLagerAktiv { get; set; }
}
