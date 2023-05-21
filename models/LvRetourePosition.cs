using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class LvRetourePosition
{
    public string? CArtNr { get; set; }

    public string? CTeilbar { get; set; }

    public int? KVaterArtikel { get; set; }

    public string? CName { get; set; }

    public string? CLieferscheinNr { get; set; }

    public int? TageSeitVersand { get; set; }

    public decimal FAnzahl { get; set; }

    public DateTime? DVersendet { get; set; }

    public int KArtikel { get; set; }

    public int KRmretoure { get; set; }

    public int KRmretourePos { get; set; }

    public int KRmstatus { get; set; }

    public int KLieferscheinPos { get; set; }

    public int KRmgrund { get; set; }

    public string? CGrundKommentar { get; set; }

    public string? CZustandKommentar { get; set; }

    public int? KZustand { get; set; }

    public byte NGutschreiben { get; set; }

    public decimal? FAnzahlLieferschein { get; set; }

    public string? CString { get; set; }

    public decimal? FVkpreis { get; set; }

    public decimal? FVknetto { get; set; }

    public decimal? FMwSt { get; set; }

    public decimal? FRabatt { get; set; }

    public string? Zustand { get; set; }

    public string? Grund { get; set; }

    public string? Status { get; set; }

    public string? CReturnItemId { get; set; }

    public string? CLagerAktiv { get; set; }

    public decimal? Ungebucht { get; set; }
}
