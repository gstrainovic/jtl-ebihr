using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TRmretourePo
{
    public int KRmretourePos { get; set; }

    public int KRmretoure { get; set; }

    public int KRmgrund { get; set; }

    public int KRmstatusVerlauf { get; set; }

    public int? KZustand { get; set; }

    public int KLieferscheinPos { get; set; }

    public int? KBenutzer { get; set; }

    public string? CZustandKommentar { get; set; }

    public string? CGrundKommentar { get; set; }

    public decimal FAnzahl { get; set; }

    public int KArtikel { get; set; }

    public byte NGutschreiben { get; set; }

    public string? CFfnReturnPosId { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public string? CArtNr { get; set; }

    public string? CName { get; set; }
}
